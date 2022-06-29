// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Emit
{

    public readonly struct EditAndContinueMethodDebugInformation
    {

        internal readonly int MethodOrdinal;

        internal readonly ImmutableArray<LocalSlotDebugInfo> LocalSlots;

        internal readonly ImmutableArray<LambdaDebugInfo> Lambdas;

        internal readonly ImmutableArray<ClosureDebugInfo> Closures;

        internal EditAndContinueMethodDebugInformation(int methodOrdinal, ImmutableArray<LocalSlotDebugInfo> localSlots, ImmutableArray<ClosureDebugInfo> closures, ImmutableArray<LambdaDebugInfo> lambdas)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(290, 998, 1414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 1219, 1253);

                f_290_1219_1252(methodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 1269, 1299);

                MethodOrdinal = methodOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 1313, 1337);

                LocalSlots = localSlots;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 1351, 1369);

                Lambdas = lambdas;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 1383, 1403);

                Closures = closures;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(290, 998, 1414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 998, 1414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 998, 1414);
            }
        }

        public static EditAndContinueMethodDebugInformation Create(ImmutableArray<byte> compressedSlotMap, ImmutableArray<byte> compressedLambdaMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(290, 1799, 2209);
                int methodOrdinal = default(int);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo> closures = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo> lambdas = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 1964, 2063);

                UncompressLambdaMap(compressedLambdaMap, out methodOrdinal
                , out closures
                , out lambdas
                );
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2077, 2198);

                return f_290_2084_2197(methodOrdinal, UncompressSlotMap(compressedSlotMap), closures, lambdas);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(290, 1799, 2209);

                Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                f_290_2084_2197(int
                methodOrdinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                localSlots, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closures, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdas)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation(methodOrdinal, localSlots, closures, lambdas);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2084, 2197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 1799, 2209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 1799, 2209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static InvalidDataException CreateInvalidDataException(ImmutableArray<byte> data, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(290, 2221, 3016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2347, 2382);

                const int
                maxReportedLength = 1024
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2398, 2454);

                int
                start = f_290_2410_2453(0, offset - maxReportedLength / 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2468, 2532);

                int
                end = f_290_2478_2531(data.Length, offset + maxReportedLength / 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2548, 2587);

                byte[]
                left = new byte[offset - start]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2601, 2642);

                data.CopyTo(start, left, 0, f_290_2629_2640(left));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2658, 2696);

                byte[]
                right = new byte[end - offset]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2710, 2754);

                data.CopyTo(offset, right, 0, f_290_2740_2752(right));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 2770, 3005);

                throw f_290_2776_3004(f_290_2801_3003(f_290_2815_2856(), offset, (DynAbs.Tracing.TraceSender.Conditional_F1(290, 2883, 2895) || (((start != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(290, 2898, 2903)) || DynAbs.Tracing.TraceSender.Conditional_F3(290, 2906, 2908))) ? "..." : "", f_290_2910_2937(left), f_290_2939_2967(right), (DynAbs.Tracing.TraceSender.Conditional_F1(290, 2969, 2989) || (((end != data.Length) && DynAbs.Tracing.TraceSender.Conditional_F2(290, 2992, 2997)) || DynAbs.Tracing.TraceSender.Conditional_F3(290, 3000, 3002))) ? "..." : ""));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(290, 2221, 3016);

                int
                f_290_2410_2453(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2410, 2453);
                    return return_v;
                }


                int
                f_290_2478_2531(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2478, 2531);
                    return return_v;
                }


                int
                f_290_2629_2640(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(290, 2629, 2640);
                    return return_v;
                }


                int
                f_290_2740_2752(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(290, 2740, 2752);
                    return return_v;
                }


                string
                f_290_2815_2856()
                {
                    var return_v = CodeAnalysisResources.InvalidDataAtOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(290, 2815, 2856);
                    return return_v;
                }


                string
                f_290_2910_2937(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2910, 2937);
                    return return_v;
                }


                string
                f_290_2939_2967(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2939, 2967);
                    return return_v;
                }


                string
                f_290_2801_3003(string
                format, params object?[]
                args)
                {
                    var return_v = string.Format(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2801, 3003);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_290_2776_3004(string
                message)
                {
                    var return_v = new System.IO.InvalidDataException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 2776, 3004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 2221, 3016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 2221, 3016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const byte
        SyntaxOffsetBaseline = 0xff
        ;

        private static unsafe ImmutableArray<LocalSlotDebugInfo> UncompressSlotMap(ImmutableArray<byte> compressedSlotMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(290, 3196, 5385);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3335, 3437) || true) && (compressedSlotMap.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 3335, 3437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3407, 3422);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(290, 3335, 3437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3453, 3517);

                var
                mapBuilder = f_290_3470_3516()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3531, 3561);

                int
                syntaxOffsetBaseline = -1
                ;

                fixed (byte*
    compressedSlotMapPtr = &compressedSlotMap.ToArray()[0]
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3678, 3758);

                    var
                    blobReader = f_290_3695_3757(compressedSlotMapPtr, compressedSlotMap.Length)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3776, 5304) || true) && (blobReader.RemainingBytes > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 3776, 5304);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4037, 4068);

                                byte
                                b = blobReader.ReadByte()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4096, 4308) || true) && (b == SyntaxOffsetBaseline)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 4096, 4308);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4183, 4242);

                                    syntaxOffsetBaseline = -blobReader.ReadCompressedInteger();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4272, 4281);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(290, 4096, 4308);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4336, 4611) || true) && (b == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 4336, 4611);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4462, 4545);

                                    f_290_4462_4544(                            // short-lived temp, no info
                                                                mapBuilder, f_290_4477_4543(SynthesizedLocalKind.LoweringTemp, default));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4575, 4584);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(290, 4336, 4611);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4639, 4689);

                                var
                                kind = (SynthesizedLocalKind)((b & 0x3f) - 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4715, 4753);

                                bool
                                hasOrdinal = (b & (1 << 7)) != 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4781, 4858);

                                int
                                syntaxOffset = blobReader.ReadCompressedInteger() + syntaxOffsetBaseline
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4886, 4952);

                                int
                                ordinal = (DynAbs.Tracing.TraceSender.Conditional_F1(290, 4900, 4910) || ((hasOrdinal && DynAbs.Tracing.TraceSender.Conditional_F2(290, 4913, 4947)) || DynAbs.Tracing.TraceSender.Conditional_F3(290, 4950, 4951))) ? blobReader.ReadCompressedInteger() : 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 4980, 5066);

                                f_290_4980_5065(
                                                        mapBuilder, f_290_4995_5064(kind, f_290_5024_5063(syntaxOffset, ordinal)));
                            }
                            catch (BadImageFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(290, 5111, 5285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5191, 5262);

                                throw CreateInvalidDataException(compressedSlotMap, blobReader.Offset);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(290, 5111, 5285);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 3776, 5304);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 3776, 5304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(290, 3776, 5304);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5335, 5374);

                return f_290_5342_5373(mapBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(290, 3196, 5385);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                f_290_3470_3516()
                {
                    var return_v = ArrayBuilder<LocalSlotDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 3470, 3516);
                    return return_v;
                }


                unsafe System.Reflection.Metadata.BlobReader
                f_290_3695_3757(byte*
                buffer, int
                length)
                {
                    var return_v = new System.Reflection.Metadata.BlobReader(buffer, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 3695, 3757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                f_290_4477_4543(Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 4477, 4543);
                    return return_v;
                }


                int
                f_290_4462_4544(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 4462, 4544);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                f_290_5024_5063(int
                syntaxOffset, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDebugId(syntaxOffset, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 5024, 5063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                f_290_4995_5064(Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 4995, 5064);
                    return return_v;
                }


                int
                f_290_4980_5065(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 4980, 5065);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                f_290_5342_5373(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 5342, 5373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 3196, 5385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 3196, 5385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SerializeLocalSlots(BlobBuilder writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(290, 5397, 6994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5475, 5505);

                int
                syntaxOffsetBaseline = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5519, 5781);
                    foreach (LocalSlotDebugInfo localSlot in f_290_5560_5570_I(LocalSlots))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 5519, 5781);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5604, 5766) || true) && (localSlot.Id.SyntaxOffset < syntaxOffsetBaseline)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 5604, 5766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5698, 5747);

                            syntaxOffsetBaseline = localSlot.Id.SyntaxOffset;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 5604, 5766);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(290, 5519, 5781);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 263);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5797, 5986) || true) && (syntaxOffsetBaseline != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 5797, 5986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5861, 5900);

                    f_290_5861_5899(writer, SyntaxOffsetBaseline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 5918, 5971);

                    f_290_5918_5970(writer, -syntaxOffsetBaseline);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(290, 5797, 5986);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6002, 6983);
                    foreach (LocalSlotDebugInfo localSlot in f_290_6043_6053_I(LocalSlots))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 6002, 6983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6087, 6141);

                        SynthesizedLocalKind
                        kind = localSlot.SynthesizedKind
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6159, 6260);

                        f_290_6159_6259(kind <= SynthesizedLocalKind.MaxValidValueForLocalVariableSerializedToDebugInformation);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6280, 6415) || true) && (!f_290_6285_6303(kind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 6280, 6415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6345, 6365);

                            f_290_6345_6364(writer, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6387, 6396);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 6280, 6415);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6435, 6461);

                        byte
                        b = (byte)(kind + 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6479, 6513);

                        f_290_6479_6512((b & (1 << 7)) == 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6533, 6576);

                        bool
                        hasOrdinal = localSlot.Id.Ordinal > 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6596, 6683) || true) && (hasOrdinal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 6596, 6683);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6652, 6664);

                            b |= 1 << 7;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 6596, 6683);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6703, 6723);

                        f_290_6703_6722(
                                        writer, b);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6741, 6821);

                        f_290_6741_6820(writer, localSlot.Id.SyntaxOffset - syntaxOffsetBaseline);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6841, 6968) || true) && (hasOrdinal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 6841, 6968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 6897, 6949);

                            f_290_6897_6948(writer, localSlot.Id.Ordinal);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 6841, 6968);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(290, 6002, 6983);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 982);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(290, 5397, 6994);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                f_290_5560_5570_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 5560, 5570);
                    return return_v;
                }


                int
                f_290_5861_5899(System.Reflection.Metadata.BlobBuilder
                this_param, byte
                value)
                {
                    this_param.WriteByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 5861, 5899);
                    return 0;
                }


                int
                f_290_5918_5970(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 5918, 5970);
                    return 0;
                }


                int
                f_290_6159_6259(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6159, 6259);
                    return 0;
                }


                bool
                f_290_6285_6303(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6285, 6303);
                    return return_v;
                }


                int
                f_290_6345_6364(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6345, 6364);
                    return 0;
                }


                int
                f_290_6479_6512(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6479, 6512);
                    return 0;
                }


                int
                f_290_6703_6722(System.Reflection.Metadata.BlobBuilder
                this_param, byte
                value)
                {
                    this_param.WriteByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6703, 6722);
                    return 0;
                }


                int
                f_290_6741_6820(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6741, 6820);
                    return 0;
                }


                int
                f_290_6897_6948(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6897, 6948);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                f_290_6043_6053_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 6043, 6053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 5397, 6994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 5397, 6994);
            }
        }

        private static unsafe void UncompressLambdaMap(
                    ImmutableArray<byte> compressedLambdaMap,
                    out int methodOrdinal,
                    out ImmutableArray<ClosureDebugInfo> closures,
                    out ImmutableArray<LambdaDebugInfo> lambdas)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(290, 7055, 9829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7336, 7377);

                methodOrdinal = DebugId.UndefinedOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7391, 7410);

                closures = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7424, 7442);

                lambdas = default;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7458, 7554) || true) && (compressedLambdaMap.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 7458, 7554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7532, 7539);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(290, 7458, 7554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7570, 7637);

                var
                closuresBuilder = f_290_7592_7636()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7651, 7716);

                var
                lambdasBuilder = f_290_7672_7715()
                ;

                fixed (byte*
    blobPtr = &compressedLambdaMap.ToArray()[0]
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 7822, 7891);

                    var
                    blobReader = f_290_7839_7890(blobPtr, compressedLambdaMap.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8114, 8169);

                        methodOrdinal = blobReader.ReadCompressedInteger() - 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8193, 8256);

                        int
                        syntaxOffsetBaseline = -blobReader.ReadCompressedInteger()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8280, 8334);

                        int
                        closureCount = blobReader.ReadCompressedInteger()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8367, 8372);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8358, 8732) || true) && (i < closureCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8392, 8395)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(290, 8358, 8732))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 8358, 8732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8445, 8499);

                                int
                                syntaxOffset = blobReader.ReadCompressedInteger()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8527, 8593);

                                var
                                closureId = f_290_8543_8592(f_290_8555_8576(closuresBuilder), generation: 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8619, 8709);

                                f_290_8619_8708(closuresBuilder, f_290_8639_8707(syntaxOffset + syntaxOffsetBaseline, closureId));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 375);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 375);
                        }
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8756, 9478) || true) && (blobReader.RemainingBytes > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 8756, 9478);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8842, 8896);

                                int
                                syntaxOffset = blobReader.ReadCompressedInteger()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 8922, 9014);

                                int
                                closureOrdinal = blobReader.ReadCompressedInteger() + LambdaDebugInfo.MinClosureOrdinal
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9042, 9234) || true) && (closureOrdinal >= closureCount)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 9042, 9234);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9134, 9207);

                                    throw CreateInvalidDataException(compressedLambdaMap, blobReader.Offset);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(290, 9042, 9234);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9262, 9326);

                                var
                                lambdaId = f_290_9277_9325(f_290_9289_9309(lambdasBuilder), generation: 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9352, 9455);

                                f_290_9352_9454(lambdasBuilder, f_290_9371_9453(syntaxOffset + syntaxOffsetBaseline, lambdaId, closureOrdinal));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(290, 8756, 9478);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 8756, 9478);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(290, 8756, 9478);
                        }
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(290, 9515, 9679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9587, 9660);

                        throw CreateInvalidDataException(compressedLambdaMap, blobReader.Offset);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(290, 9515, 9679);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9710, 9758);

                closures = f_290_9721_9757(closuresBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9772, 9818);

                lambdas = f_290_9782_9817(lambdasBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(290, 7055, 9829);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_290_7592_7636()
                {
                    var return_v = ArrayBuilder<ClosureDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 7592, 7636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_290_7672_7715()
                {
                    var return_v = ArrayBuilder<LambdaDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 7672, 7715);
                    return return_v;
                }


                unsafe System.Reflection.Metadata.BlobReader
                f_290_7839_7890(byte*
                buffer, int
                length)
                {
                    var return_v = new System.Reflection.Metadata.BlobReader(buffer, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 7839, 7890);
                    return return_v;
                }


                int
                f_290_8555_8576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(290, 8555, 8576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_290_8543_8592(int
                ordinal, int
                generation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation: generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 8543, 8592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo
                f_290_8639_8707(int
                syntaxOffset, Microsoft.CodeAnalysis.CodeGen.DebugId
                closureId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo(syntaxOffset, closureId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 8639, 8707);
                    return return_v;
                }


                int
                f_290_8619_8708(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                this_param, Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 8619, 8708);
                    return 0;
                }


                int
                f_290_9289_9309(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(290, 9289, 9309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_290_9277_9325(int
                ordinal, int
                generation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation: generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9277, 9325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo
                f_290_9371_9453(int
                syntaxOffset, Microsoft.CodeAnalysis.CodeGen.DebugId
                lambdaId, int
                closureOrdinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo(syntaxOffset, lambdaId, closureOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9371, 9453);
                    return return_v;
                }


                int
                f_290_9352_9454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param, Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9352, 9454);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_290_9721_9757(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9721, 9757);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_290_9782_9817(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9782, 9817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 7055, 9829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 7055, 9829);
            }
        }

        internal void SerializeLambdaMap(BlobBuilder writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(290, 9841, 11318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9918, 9952);

                f_290_9918_9951(MethodOrdinal >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 9966, 10015);

                f_290_9966_10014(writer, MethodOrdinal + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10031, 10061);

                int
                syntaxOffsetBaseline = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10075, 10312);
                    foreach (ClosureDebugInfo info in f_290_10109_10117_I(Closures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 10075, 10312);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10151, 10297) || true) && (info.SyntaxOffset < syntaxOffsetBaseline)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 10151, 10297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10237, 10278);

                            syntaxOffsetBaseline = info.SyntaxOffset;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 10151, 10297);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(290, 10075, 10312);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 238);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10328, 10563);
                    foreach (LambdaDebugInfo info in f_290_10361_10368_I(Lambdas))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 10328, 10563);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10402, 10548) || true) && (info.SyntaxOffset < syntaxOffsetBaseline)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 10402, 10548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10488, 10529);

                            syntaxOffsetBaseline = info.SyntaxOffset;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(290, 10402, 10548);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(290, 10328, 10563);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10579, 10632);

                f_290_10579_10631(
                            writer, -syntaxOffsetBaseline);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10646, 10693);

                f_290_10646_10692(writer, Closures.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10709, 10872);
                    foreach (ClosureDebugInfo info in f_290_10743_10751_I(Closures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 10709, 10872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10785, 10857);

                        f_290_10785_10856(writer, info.SyntaxOffset - syntaxOffsetBaseline);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(290, 10709, 10872);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 164);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10888, 11307);
                    foreach (LambdaDebugInfo info in f_290_10921_10928_I(Lambdas))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(290, 10888, 11307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 10962, 11033);

                        f_290_10962_11032(info.ClosureOrdinal >= LambdaDebugInfo.MinClosureOrdinal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 11051, 11095);

                        f_290_11051_11094(info.LambdaId.Generation == 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 11115, 11187);

                        f_290_11115_11186(
                                        writer, info.SyntaxOffset - syntaxOffsetBaseline);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 11205, 11292);

                        f_290_11205_11291(writer, info.ClosureOrdinal - LambdaDebugInfo.MinClosureOrdinal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(290, 10888, 11307);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(290, 1, 420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(290, 1, 420);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(290, 9841, 11318);

                int
                f_290_9918_9951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9918, 9951);
                    return 0;
                }


                int
                f_290_9966_10014(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 9966, 10014);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_290_10109_10117_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10109, 10117);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_290_10361_10368_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10361, 10368);
                    return return_v;
                }


                int
                f_290_10579_10631(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10579, 10631);
                    return 0;
                }


                int
                f_290_10646_10692(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10646, 10692);
                    return 0;
                }


                int
                f_290_10785_10856(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10785, 10856);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_290_10743_10751_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10743, 10751);
                    return return_v;
                }


                int
                f_290_10962_11032(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10962, 11032);
                    return 0;
                }


                int
                f_290_11051_11094(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 11051, 11094);
                    return 0;
                }


                int
                f_290_11115_11186(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 11115, 11186);
                    return 0;
                }


                int
                f_290_11205_11291(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 11205, 11291);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_290_10921_10928_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 10921, 10928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(290, 9841, 11318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 9841, 11318);
            }
        }
        static EditAndContinueMethodDebugInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(290, 661, 11347);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(290, 3078, 3105);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(290, 661, 11347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(290, 661, 11347);
        }

        static int
        f_290_1219_1252(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(290, 1219, 1252);
            return 0;
        }


    }
}
