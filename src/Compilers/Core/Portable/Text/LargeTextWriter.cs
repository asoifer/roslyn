// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class LargeTextWriter : SourceTextWriter
    {
        private readonly Encoding? _encoding;

        private readonly SourceHashAlgorithm _checksumAlgorithm;

        private readonly ArrayBuilder<char[]> _chunks;

        private readonly int _bufferSize;

        private char[]? _buffer;

        private int _currentUsed;

        public LargeTextWriter(Encoding? encoding, SourceHashAlgorithm checksumAlgorithm, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(716, 731, 1091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 473, 482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 530, 548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 597, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 638, 649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 676, 683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 706, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 849, 870);

                _encoding = encoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 884, 923);

                _checksumAlgorithm = checksumAlgorithm;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 937, 1014);

                _chunks = f_716_947_1013(1 + length / LargeText.ChunkSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1028, 1080);

                _bufferSize = f_716_1042_1079(LargeText.ChunkSize, length);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(716, 731, 1091);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 731, 1091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 731, 1091);
            }
        }

        public override SourceText ToSourceText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 1103, 1351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1169, 1182);

                f_716_1169_1181(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1196, 1340);

                return f_716_1203_1339(f_716_1217_1245(_chunks), _encoding, default(ImmutableArray<byte>), _checksumAlgorithm, default(ImmutableArray<byte>));
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 1103, 1351);

                int
                f_716_1169_1181(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 1169, 1181);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<char[]>
                f_716_1217_1245(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 1217, 1245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LargeText
                f_716_1203_1339(System.Collections.Immutable.ImmutableArray<char[]>
                chunks, System.Text.Encoding?
                encodingOpt, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                embeddedTextBlob)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LargeText(chunks, encodingOpt, checksum, checksumAlgorithm, embeddedTextBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 1203, 1339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 1103, 1351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 1103, 1351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Encoding Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 1479, 1505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1485, 1503);

                    return _encoding!;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(716, 1479, 1505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 1421, 1516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 1421, 1516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool CanFitInAllocatedBuffer(int chars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 1528, 1677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1599, 1666);

                return _buffer != null && (DynAbs.Tracing.TraceSender.Expression_True(716, 1606, 1665) && chars <= (f_716_1635_1649(_buffer) - _currentUsed));
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 1528, 1677);

                int
                f_716_1635_1649(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 1635, 1649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 1528, 1677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 1528, 1677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Write(char value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 1689, 2027);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1752, 2016) || true) && (_buffer != null && (DynAbs.Tracing.TraceSender.Expression_True(716, 1756, 1804) && _currentUsed < f_716_1790_1804(_buffer)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 1752, 2016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1838, 1868);

                    _buffer[_currentUsed] = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1886, 1901);

                    _currentUsed++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 1752, 2016);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 1752, 2016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 1967, 2001);

                    f_716_1967_2000(this, new char[] { value }, 0, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 1752, 2016);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 1689, 2027);

                int
                f_716_1790_1804(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 1790, 1804);
                    return return_v;
                }


                int
                f_716_1967_2000(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param, char[]
                chars, int
                index, int
                count)
                {
                    this_param.Write(chars, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 1967, 2000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 1689, 2027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 1689, 2027);
            }
        }

        public override void Write(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 2039, 2811);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2105, 2800) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 2105, 2800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2156, 2181);

                    var
                    count = f_716_2168_2180(value)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2199, 2213);

                    int
                    index = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2233, 2785) || true) && (count > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 2233, 2785);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2291, 2306);

                            f_716_2291_2305(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2330, 2377);

                            var
                            remaining = f_716_2346_2361(_buffer!) - _currentUsed
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2399, 2437);

                            var
                            copy = f_716_2410_2436(remaining, count)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2461, 2510);

                            f_716_2461_2509(
                                                value, index, _buffer, _currentUsed, copy);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2534, 2555);

                            _currentUsed += copy;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2577, 2591);

                            index += copy;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2613, 2627);

                            count -= copy;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2651, 2766) || true) && (_currentUsed == f_716_2671_2685(_buffer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 2651, 2766);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2735, 2743);

                                f_716_2735_2742(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(716, 2651, 2766);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(716, 2233, 2785);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(716, 2233, 2785);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(716, 2233, 2785);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 2105, 2800);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 2039, 2811);

                int
                f_716_2168_2180(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 2168, 2180);
                    return return_v;
                }


                int
                f_716_2291_2305(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param)
                {
                    this_param.EnsureBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 2291, 2305);
                    return 0;
                }


                int
                f_716_2346_2361(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 2346, 2361);
                    return return_v;
                }


                int
                f_716_2410_2436(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 2410, 2436);
                    return return_v;
                }


                int
                f_716_2461_2509(string
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 2461, 2509);
                    return 0;
                }


                int
                f_716_2671_2685(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 2671, 2685);
                    return return_v;
                }


                int
                f_716_2735_2742(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 2735, 2742);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 2039, 2811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 2039, 2811);
            }
        }

        public override void Write(char[] chars, int index, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 2823, 3743);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2910, 3050) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(716, 2914, 2948) || index >= f_716_2936_2948(chars)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 2910, 3050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 2982, 3035);

                    throw f_716_2988_3034(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 2910, 3050);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3066, 3213) || true) && (count < 0 || (DynAbs.Tracing.TraceSender.Expression_False(716, 3070, 3111) || count > f_716_3091_3103(chars) - index))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 3066, 3213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3145, 3198);

                    throw f_716_3151_3197(nameof(count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 3066, 3213);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3229, 3732) || true) && (count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 3229, 3732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3279, 3294);

                        f_716_3279_3293(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3314, 3361);

                        var
                        remaining = f_716_3330_3345(_buffer!) - _currentUsed
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3379, 3417);

                        var
                        copy = f_716_3390_3416(remaining, count)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3437, 3491);

                        f_716_3437_3490(chars, index, _buffer, _currentUsed, copy);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3509, 3530);

                        _currentUsed += copy;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3548, 3562);

                        index += copy;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3580, 3594);

                        count -= copy;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3614, 3717) || true) && (_currentUsed == f_716_3634_3648(_buffer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 3614, 3717);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3690, 3698);

                            f_716_3690_3697(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(716, 3614, 3717);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(716, 3229, 3732);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(716, 3229, 3732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(716, 3229, 3732);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 2823, 3743);

                int
                f_716_2936_2948(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 2936, 2948);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_716_2988_3034(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 2988, 3034);
                    return return_v;
                }


                int
                f_716_3091_3103(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 3091, 3103);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_716_3151_3197(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 3151, 3197);
                    return return_v;
                }


                int
                f_716_3279_3293(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param)
                {
                    this_param.EnsureBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 3279, 3293);
                    return 0;
                }


                int
                f_716_3330_3345(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 3330, 3345);
                    return return_v;
                }


                int
                f_716_3390_3416(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 3390, 3416);
                    return return_v;
                }


                int
                f_716_3437_3490(char[]
                sourceArray, int
                sourceIndex, char[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 3437, 3490);
                    return 0;
                }


                int
                f_716_3634_3648(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 3634, 3648);
                    return return_v;
                }


                int
                f_716_3690_3697(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 3690, 3697);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 2823, 3743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 2823, 3743);
            }
        }

        internal void AppendChunk(char[] chunk)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 3861, 4177);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 3925, 4166) || true) && (f_716_3929_3966(this, f_716_3953_3965(chunk)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 3925, 4166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4000, 4035);

                    f_716_4000_4034(this, chunk, 0, f_716_4021_4033(chunk));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 3925, 4166);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 3925, 4166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4101, 4114);

                    f_716_4101_4113(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4132, 4151);

                    f_716_4132_4150(_chunks, chunk);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 3925, 4166);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 3861, 4177);

                int
                f_716_3953_3965(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 3953, 3965);
                    return return_v;
                }


                bool
                f_716_3929_3966(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param, int
                chars)
                {
                    var return_v = this_param.CanFitInAllocatedBuffer(chars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 3929, 3966);
                    return return_v;
                }


                int
                f_716_4021_4033(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 4021, 4033);
                    return return_v;
                }


                int
                f_716_4000_4034(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param, char[]
                chars, int
                index, int
                count)
                {
                    this_param.Write(chars, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 4000, 4034);
                    return 0;
                }


                int
                f_716_4101_4113(Microsoft.CodeAnalysis.Text.LargeTextWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 4101, 4113);
                    return 0;
                }


                int
                f_716_4132_4150(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
                this_param, char[]
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 4132, 4150);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 3861, 4177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 3861, 4177);
            }
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 4189, 4584);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4242, 4573) || true) && (_buffer != null && (DynAbs.Tracing.TraceSender.Expression_True(716, 4246, 4281) && _currentUsed > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 4242, 4573);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4315, 4449) || true) && (_currentUsed < f_716_4334_4348(_buffer))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 4315, 4449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4390, 4430);

                        f_716_4390_4429(ref _buffer, _currentUsed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(716, 4315, 4449);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4469, 4490);

                    f_716_4469_4489(
                                    _chunks, _buffer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4508, 4523);

                    _buffer = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4541, 4558);

                    _currentUsed = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 4242, 4573);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 4189, 4584);

                int
                f_716_4334_4348(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(716, 4334, 4348);
                    return return_v;
                }


                int
                f_716_4390_4429(ref char[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 4390, 4429);
                    return 0;
                }


                int
                f_716_4469_4489(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
                this_param, char[]
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 4469, 4489);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 4189, 4584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 4189, 4584);
            }
        }

        private void EnsureBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(716, 4596, 4759);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4648, 4748) || true) && (_buffer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(716, 4648, 4748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(716, 4701, 4733);

                    _buffer = new char[_bufferSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(716, 4648, 4748);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(716, 4596, 4759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(716, 4596, 4759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 4596, 4759);
            }
        }

        static LargeTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(716, 373, 4766);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(716, 373, 4766);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(716, 373, 4766);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(716, 373, 4766);

        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<char[]>
        f_716_947_1013(int
        capacity)
        {
            var return_v = ArrayBuilder<char[]>.GetInstance(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 947, 1013);
            return return_v;
        }


        static int
        f_716_1042_1079(int
        val1, int
        val2)
        {
            var return_v = Math.Min(val1, val2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(716, 1042, 1079);
            return return_v;
        }

    }
}
