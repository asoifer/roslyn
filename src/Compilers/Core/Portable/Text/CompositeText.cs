// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class CompositeText : SourceText
    {
        private readonly ImmutableArray<SourceText> _segments;

        private readonly int _length;

        private readonly int _storageSize;

        private readonly int[] _segmentOffsets;

        private readonly Encoding? _encoding;

        private CompositeText(ImmutableArray<SourceText> segments, Encoding? encoding, SourceHashAlgorithm checksumAlgorithm)
        : base(checksumAlgorithm: f_714_1050_1086_C(checksumAlgorithm))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(714, 912, 1595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 752, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 791, 803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 837, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 890, 899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1112, 1153);

                f_714_1112_1152(f_714_1125_1151_M(!segments.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1169, 1190);

                _segments = segments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1204, 1225);

                _encoding = encoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1241, 1310);

                f_714_1241_1309(segments, out _length, out _storageSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1326, 1369);

                _segmentOffsets = new int[segments.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1383, 1398);

                int
                offset = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1421, 1426);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1412, 1584) || true) && (i < f_714_1432_1454(_segmentOffsets))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1456, 1459)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 1412, 1584))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 1412, 1584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1493, 1521);

                        _segmentOffsets[i] = offset;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1539, 1569);

                        offset += f_714_1549_1568(_segments[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 173);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(714, 912, 1595);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 912, 1595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 912, 1595);
            }
        }

        public override Encoding? Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 1666, 1691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1672, 1689);

                    return _encoding;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(714, 1666, 1691);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 1607, 1702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 1607, 1702);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 1765, 1788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1771, 1786);

                    return _length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(714, 1765, 1788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 1714, 1799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 1714, 1799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int StorageSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 1869, 1897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 1875, 1895);

                    return _storageSize;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(714, 1869, 1897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 1811, 1908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 1811, 1908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<SourceText> Segments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 1998, 2023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2004, 2021);

                    return _segments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(714, 1998, 2023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 1920, 2034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 1920, 2034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override char this[int position]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 2110, 2319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2146, 2156);

                    int
                    index
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2174, 2185);

                    int
                    offset
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2203, 2254);

                    f_714_2203_2253(this, position, out index, out offset);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2272, 2304);

                    return f_714_2279_2303(_segments[index], offset);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(714, 2110, 2319);

                    int
                    f_714_2203_2253(Microsoft.CodeAnalysis.Text.CompositeText
                    this_param, int
                    position, out int
                    index, out int
                    offset)
                    {
                        this_param.GetIndexAndOffset(position, out index, out offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 2203, 2253);
                        return 0;
                    }


                    char
                    f_714_2279_2303(Microsoft.CodeAnalysis.Text.SourceText
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 2279, 2303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 2110, 2319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 2110, 2319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SourceText GetSubText(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 2342, 3415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2419, 2438);

                f_714_2419_2437(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2454, 2483);

                var
                sourceIndex = span.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2497, 2521);

                var
                count = span.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2537, 2550);

                int
                segIndex
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2564, 2578);

                int
                segOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2592, 2652);

                f_714_2592_2651(this, sourceIndex, out segIndex, out segOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2668, 2725);

                var
                newSegments = f_714_2686_2724()
                ;
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2775, 3219) || true) && (segIndex < _segments.Length && (DynAbs.Tracing.TraceSender.Expression_True(714, 2782, 2822) && count > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 2775, 3219);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2864, 2898);

                            var
                            segment = _segments[segIndex]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 2920, 2981);

                            var
                            copyLength = f_714_2937_2980(count, f_714_2953_2967(segment) - segOffset)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3005, 3087);

                            f_714_3005_3086(newSegments, f_714_3030_3085(segment, f_714_3049_3084(segOffset, copyLength)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3111, 3131);

                            count -= copyLength;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3153, 3164);

                            segIndex++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3186, 3200);

                            segOffset = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(714, 2775, 3219);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 2775, 3219);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(714, 2775, 3219);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3239, 3301);

                    return f_714_3246_3300(newSegments, this, adjustSegments: false);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(714, 3330, 3404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3370, 3389);

                    f_714_3370_3388(newSegments);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(714, 3330, 3404);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(714, 2342, 3415);

                int
                f_714_2419_2437(Microsoft.CodeAnalysis.Text.CompositeText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.CheckSubSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 2419, 2437);
                    return 0;
                }


                int
                f_714_2592_2651(Microsoft.CodeAnalysis.Text.CompositeText
                this_param, int
                position, out int
                index, out int
                offset)
                {
                    this_param.GetIndexAndOffset(position, out index, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 2592, 2651);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                f_714_2686_2724()
                {
                    var return_v = ArrayBuilder<SourceText>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 2686, 2724);
                    return return_v;
                }


                int
                f_714_2953_2967(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 2953, 2967);
                    return return_v;
                }


                int
                f_714_2937_2980(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 2937, 2980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_714_3049_3084(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 3049, 3084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_3030_3085(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetSubText(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 3030, 3085);
                    return return_v;
                }


                int
                f_714_3005_3086(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    AddSegments(segments, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 3005, 3086);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_3246_3300(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, Microsoft.CodeAnalysis.Text.CompositeText
                original, bool
                adjustSegments)
                {
                    var return_v = ToSourceText(segments, (Microsoft.CodeAnalysis.Text.SourceText)original, adjustSegments: adjustSegments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 3246, 3300);
                    return return_v;
                }


                int
                f_714_3370_3388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 3370, 3388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 2342, 3415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 2342, 3415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetIndexAndOffset(int position, out int index, out int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 3427, 3776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3609, 3658);

                int
                idx = f_714_3619_3657(_segmentOffsets, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3672, 3708);

                index = (DynAbs.Tracing.TraceSender.Conditional_F1(714, 3680, 3688) || ((idx >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(714, 3691, 3694)) || DynAbs.Tracing.TraceSender.Conditional_F3(714, 3697, 3707))) ? idx : (~idx - 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 3722, 3765);

                offset = position - _segmentOffsets[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(714, 3427, 3776);

                int
                f_714_3619_3657(int[]
                array, int
                value)
                {
                    var return_v = array.BinarySearch(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 3619, 3657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 3427, 3776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 3427, 3776);
            }
        }

        private bool CheckCopyToArguments(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 4014, 4704);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4142, 4237) || true) && (destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 4142, 4237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4184, 4237);

                    throw f_714_4190_4236(nameof(destination));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 4142, 4237);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4253, 4350) || true) && (sourceIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 4253, 4350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4291, 4350);

                    throw f_714_4297_4349(nameof(sourceIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 4253, 4350);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4366, 4473) || true) && (destinationIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 4366, 4473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4409, 4473);

                    throw f_714_4415_4472(nameof(destinationIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 4366, 4473);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4489, 4660) || true) && (count < 0 || (DynAbs.Tracing.TraceSender.Expression_False(714, 4493, 4539) || count > f_714_4514_4525(this) - sourceIndex) || (DynAbs.Tracing.TraceSender.Expression_False(714, 4493, 4588) || count > f_714_4551_4569(destination) - destinationIndex))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 4489, 4660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4607, 4660);

                    throw f_714_4613_4659(nameof(count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 4489, 4660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4676, 4693);

                return count > 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(714, 4014, 4704);

                System.ArgumentNullException
                f_714_4190_4236(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 4190, 4236);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_714_4297_4349(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 4297, 4349);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_714_4415_4472(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 4415, 4472);
                    return return_v;
                }


                int
                f_714_4514_4525(Microsoft.CodeAnalysis.Text.CompositeText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 4514, 4525);
                    return return_v;
                }


                int
                f_714_4551_4569(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 4551, 4569);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_714_4613_4659(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 4613, 4659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 4014, 4704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 4014, 4704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(714, 4716, 5546);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4838, 4940) || true) && (!f_714_4843_4914(this, sourceIndex, destination, destinationIndex, count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 4838, 4940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4933, 4940);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 4838, 4940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4956, 4969);

                int
                segIndex
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 4983, 4997);

                int
                segOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5011, 5071);

                f_714_5011_5070(this, sourceIndex, out segIndex, out segOffset);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5087, 5535) || true) && (segIndex < _segments.Length && (DynAbs.Tracing.TraceSender.Expression_True(714, 5094, 5134) && count > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 5087, 5535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5168, 5202);

                        var
                        segment = _segments[segIndex]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5220, 5281);

                        var
                        copyLength = f_714_5237_5280(count, f_714_5253_5267(segment) - segOffset)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5301, 5370);

                        f_714_5301_5369(
                                        segment, segOffset, destination, destinationIndex, copyLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5390, 5410);

                        count -= copyLength;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5428, 5459);

                        destinationIndex += copyLength;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5477, 5488);

                        segIndex++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5506, 5520);

                        segOffset = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 5087, 5535);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 5087, 5535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 5087, 5535);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(714, 4716, 5546);

                bool
                f_714_4843_4914(Microsoft.CodeAnalysis.Text.CompositeText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    var return_v = this_param.CheckCopyToArguments(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 4843, 4914);
                    return return_v;
                }


                int
                f_714_5011_5070(Microsoft.CodeAnalysis.Text.CompositeText
                this_param, int
                position, out int
                index, out int
                offset)
                {
                    this_param.GetIndexAndOffset(position, out index, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 5011, 5070);
                    return 0;
                }


                int
                f_714_5253_5267(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 5253, 5267);
                    return return_v;
                }


                int
                f_714_5237_5280(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 5237, 5280);
                    return return_v;
                }


                int
                f_714_5301_5369(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 5301, 5369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 4716, 5546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 4716, 5546);
            }
        }

        internal static void AddSegments(ArrayBuilder<SourceText> segments, SourceText text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 5558, 5935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5667, 5716);

                CompositeText?
                composite = text as CompositeText
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5730, 5924) || true) && (composite == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 5730, 5924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5785, 5804);

                    f_714_5785_5803(segments, text);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 5730, 5924);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 5730, 5924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 5870, 5909);

                    f_714_5870_5908(segments, composite._segments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 5730, 5924);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 5558, 5935);

                int
                f_714_5785_5803(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 5785, 5803);
                    return 0;
                }


                int
                f_714_5870_5908(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.SourceText>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 5870, 5908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 5558, 5935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 5558, 5935);
            }
        }

        internal static SourceText ToSourceText(ArrayBuilder<SourceText> segments, SourceText original, bool adjustSegments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 5947, 6699);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6088, 6244) || true) && (adjustSegments)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 6088, 6244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6140, 6171);

                    f_714_6140_6170(segments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6189, 6229);

                    f_714_6189_6228(segments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 6088, 6244);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6260, 6688) || true) && (f_714_6264_6278(segments) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 6260, 6688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6317, 6401);

                    return f_714_6324_6400(string.Empty, f_714_6354_6371(original), f_714_6373_6399(original));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 6260, 6688);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 6260, 6688);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6435, 6688) || true) && (f_714_6439_6453(segments) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 6435, 6688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6492, 6511);

                        return f_714_6499_6510(segments, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 6435, 6688);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 6435, 6688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6577, 6673);

                        return f_714_6584_6672(f_714_6602_6624(segments), f_714_6626_6643(original), f_714_6645_6671(original));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 6435, 6688);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 6260, 6688);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 5947, 6699);

                int
                f_714_6140_6170(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments)
                {
                    TrimInaccessibleText(segments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 6140, 6170);
                    return 0;
                }


                int
                f_714_6189_6228(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments)
                {
                    ReduceSegmentCountIfNecessary(segments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 6189, 6228);
                    return 0;
                }


                int
                f_714_6264_6278(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6264, 6278);
                    return return_v;
                }


                System.Text.Encoding?
                f_714_6354_6371(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6354, 6371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_714_6373_6399(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6373, 6399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_6324_6400(string
                text, System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = SourceText.From(text, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 6324, 6400);
                    return return_v;
                }


                int
                f_714_6439_6453(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6439, 6453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_6499_6510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6499, 6510);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.SourceText>
                f_714_6602_6624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 6602, 6624);
                    return return_v;
                }


                System.Text.Encoding?
                f_714_6626_6643(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6626, 6643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_714_6645_6671(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 6645, 6671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.CompositeText
                f_714_6584_6672(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.SourceText>
                segments, System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.CompositeText(segments, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 6584, 6672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 5947, 6699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 5947, 6699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const int
        TARGET_SEGMENT_COUNT_AFTER_REDUCTION = 32
        ;

        internal const int
        MAXIMUM_SEGMENT_COUNT_BEFORE_REDUCTION = 64
        ;

        private static void ReduceSegmentCountIfNecessary(ArrayBuilder<SourceText> segments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 7132, 7484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 7241, 7473) || true) && (f_714_7245_7259(segments) > MAXIMUM_SEGMENT_COUNT_BEFORE_REDUCTION)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 7241, 7473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 7334, 7401);

                    var
                    segmentSize = f_714_7352_7400(segments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 7419, 7458);

                    f_714_7419_7457(segments, segmentSize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 7241, 7473);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 7132, 7484);

                int
                f_714_7245_7259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 7245, 7259);
                    return return_v;
                }


                int
                f_714_7352_7400(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments)
                {
                    var return_v = GetMinimalSegmentSizeToUseForCombining(segments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 7352, 7400);
                    return return_v;
                }


                int
                f_714_7419_7457(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, int
                segmentSize)
                {
                    CombineSegments(segments, segmentSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 7419, 7457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 7132, 7484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 7132, 7484);
            }
        }

        private const int
        INITIAL_SEGMENT_SIZE_FOR_COMBINING = 32
        ;

        private const int
        MAXIMUM_SEGMENT_SIZE_FOR_COMBINING = int.MaxValue / 16
        ;

        private static int GetMinimalSegmentSizeToUseForCombining(ArrayBuilder<SourceText> segments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 8215, 8906);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 8465, 8513);
                    // find the minimal segment size that reduces enough segments to less that or equal to the ideal segment count
                    for (var
        segmentSize = INITIAL_SEGMENT_SIZE_FOR_COMBINING
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 8456, 8837) || true) && (segmentSize <= MAXIMUM_SEGMENT_SIZE_FOR_COMBINING)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 8600, 8616)
        , segmentSize *= 2, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 8456, 8837))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 8456, 8837);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 8650, 8822) || true) && (f_714_8654_8702(segments, segmentSize) <= TARGET_SEGMENT_COUNT_AFTER_REDUCTION)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 8650, 8822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 8784, 8803);

                            return segmentSize;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(714, 8650, 8822);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 8853, 8895);

                return MAXIMUM_SEGMENT_SIZE_FOR_COMBINING;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 8215, 8906);

                int
                f_714_8654_8702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, int
                segmentSize)
                {
                    var return_v = GetSegmentCountIfCombined(segments, segmentSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 8654, 8702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 8215, 8906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 8215, 8906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetSegmentCountIfCombined(ArrayBuilder<SourceText> segments, int segmentSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 9133, 10158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9254, 9286);

                int
                numberOfSegmentsReduced = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9311, 9316);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9302, 10083) || true) && (i < f_714_9322_9336(segments) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9342, 9345)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 9302, 10083))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 9302, 10083);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9379, 10068) || true) && (f_714_9383_9401(f_714_9383_9394(segments, i)) <= segmentSize)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 9379, 10068);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9533, 9547);

                            int
                            count = 1
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9578, 9587);
                                for (int
            j = i + 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9569, 9815) || true) && (j < f_714_9593_9607(segments))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9609, 9612)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 9569, 9815))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 9569, 9815);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9662, 9792) || true) && (f_714_9666_9684(f_714_9666_9677(segments, j)) <= segmentSize)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 9662, 9792);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9757, 9765);

                                        count++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 9662, 9792);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 247);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 247);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9839, 10049) || true) && (count > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 9839, 10049);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9902, 9926);

                                var
                                removed = count - 1
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 9952, 9987);

                                numberOfSegmentsReduced += removed;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10013, 10026);

                                i += removed;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(714, 9839, 10049);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(714, 9379, 10068);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10099, 10147);

                return f_714_10106_10120(segments) - numberOfSegmentsReduced;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 9133, 10158);

                int
                f_714_9322_9336(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 9322, 9336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_9383_9394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 9383, 9394);
                    return return_v;
                }


                int
                f_714_9383_9401(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 9383, 9401);
                    return return_v;
                }


                int
                f_714_9593_9607(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 9593, 9607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_9666_9677(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 9666, 9677);
                    return return_v;
                }


                int
                f_714_9666_9684(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 9666, 9684);
                    return return_v;
                }


                int
                f_714_10106_10120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10106, 10120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 9133, 10158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 9133, 10158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CombineSegments(ArrayBuilder<SourceText> segments, int segmentSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 10336, 11907);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10457, 10462);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10448, 11896) || true) && (i < f_714_10468_10482(segments) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10488, 10491)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 10448, 11896))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 10448, 11896);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10525, 11881) || true) && (f_714_10529_10547(f_714_10529_10540(segments, i)) <= segmentSize)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 10525, 11881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10604, 10644);

                            int
                            combinedLength = f_714_10625_10643(f_714_10625_10636(segments, i))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10741, 10755);

                            int
                            count = 1
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10786, 10795);
                                for (int
            j = i + 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10777, 11090) || true) && (j < f_714_10801_10815(segments))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10817, 10820)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 10777, 11090))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 10777, 11090);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10870, 11067) || true) && (f_714_10874_10892(f_714_10874_10885(segments, j)) <= segmentSize)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 10870, 11067);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 10965, 10973);

                                        count++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11003, 11040);

                                        combinedLength += f_714_11021_11039(f_714_11021_11032(segments, j));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 10870, 11067);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 314);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 314);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11202, 11862) || true) && (count > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 11202, 11862);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11265, 11301);

                                var
                                encoding = f_714_11280_11300(f_714_11280_11291(segments, i))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11327, 11373);

                                var
                                algorithm = f_714_11343_11372(f_714_11343_11354(segments, i))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11401, 11475);

                                var
                                writer = f_714_11414_11474(encoding, algorithm, combinedLength)
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11503, 11719) || true) && (count > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 11503, 11719);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11577, 11603);

                                        f_714_11577_11602(f_714_11577_11588(segments, i), writer);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11633, 11654);

                                        f_714_11633_11653(segments, i);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11684, 11692);

                                        count--;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 11503, 11719);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 11503, 11719);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 11503, 11719);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11747, 11783);

                                var
                                newText = f_714_11761_11782(writer)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11811, 11839);

                                f_714_11811_11838(
                                                        segments, i, newText);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(714, 11202, 11862);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(714, 10525, 11881);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 1449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 1449);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 10336, 11907);

                int
                f_714_10468_10482(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10468, 10482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_10529_10540(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10529, 10540);
                    return return_v;
                }


                int
                f_714_10529_10547(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10529, 10547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_10625_10636(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10625, 10636);
                    return return_v;
                }


                int
                f_714_10625_10643(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10625, 10643);
                    return return_v;
                }


                int
                f_714_10801_10815(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10801, 10815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_10874_10885(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10874, 10885);
                    return return_v;
                }


                int
                f_714_10874_10892(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 10874, 10892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_11021_11032(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11021, 11032);
                    return return_v;
                }


                int
                f_714_11021_11039(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11021, 11039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_11280_11291(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11280, 11291);
                    return return_v;
                }


                System.Text.Encoding?
                f_714_11280_11300(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11280, 11300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_11343_11354(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11343, 11354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_714_11343_11372(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11343, 11372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceTextWriter
                f_714_11414_11474(System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, int
                length)
                {
                    var return_v = SourceTextWriter.Create(encoding, checksumAlgorithm, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 11414, 11474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_11577_11588(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 11577, 11588);
                    return return_v;
                }


                int
                f_714_11577_11602(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceTextWriter
                textWriter)
                {
                    this_param.Write((System.IO.TextWriter)textWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 11577, 11602);
                    return 0;
                }


                int
                f_714_11633_11653(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 11633, 11653);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_11761_11782(Microsoft.CodeAnalysis.Text.SourceTextWriter
                this_param)
                {
                    var return_v = this_param.ToSourceText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 11761, 11782);
                    return return_v;
                }


                int
                f_714_11811_11838(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                index, Microsoft.CodeAnalysis.Text.SourceText
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 11811, 11838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 10336, 11907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 10336, 11907);
            }
        }

        private static readonly ObjectPool<HashSet<SourceText>> s_uniqueSourcesPool
        ;

        private static void ComputeLengthAndStorageSize(IReadOnlyList<SourceText> segments, out int length, out int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 12219, 12918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12357, 12408);

                var
                uniqueSources = f_714_12377_12407(s_uniqueSourcesPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12424, 12435);

                length = 0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12458, 12463);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12449, 12662) || true) && (i < f_714_12469_12483(segments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12485, 12488)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(714, 12449, 12662))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 12449, 12662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12522, 12548);

                        var
                        segment = f_714_12536_12547(segments, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12566, 12591);

                        length += f_714_12576_12590(segment);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12609, 12647);

                        f_714_12609_12646(uniqueSources, f_714_12627_12645(segment));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12678, 12687);

                size = 0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12701, 12815);
                    foreach (var segment in f_714_12725_12738_I(uniqueSources))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 12701, 12815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12772, 12800);

                        size += f_714_12780_12799(segment);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(714, 12701, 12815);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12831, 12853);

                f_714_12831_12852(
                            uniqueSources);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 12867, 12907);

                f_714_12867_12906(s_uniqueSourcesPool, uniqueSources);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 12219, 12918);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                f_714_12377_12407(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 12377, 12407);
                    return return_v;
                }


                int
                f_714_12469_12483(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 12469, 12483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_12536_12547(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 12536, 12547);
                    return return_v;
                }


                int
                f_714_12576_12590(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 12576, 12590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_12627_12645(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.StorageKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 12627, 12645);
                    return return_v;
                }


                bool
                f_714_12609_12646(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 12609, 12646);
                    return return_v;
                }


                int
                f_714_12780_12799(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.StorageSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 12780, 12799);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                f_714_12725_12738_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 12725, 12738);
                    return return_v;
                }


                int
                f_714_12831_12852(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 12831, 12852);
                    return 0;
                }


                int
                f_714_12867_12906(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>>
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 12867, 12906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 12219, 12918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 12219, 12918);
            }
        }

        private static void TrimInaccessibleText(ArrayBuilder<SourceText> segments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(714, 13024, 13817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13124, 13141);

                int
                length
                = default(int),
                size
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13155, 13215);

                f_714_13155_13214(segments, out length, out size);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13326, 13806) || true) && (length < size / 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 13326, 13806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13381, 13417);

                    var
                    encoding = f_714_13396_13416(f_714_13396_13407(segments, 0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13435, 13481);

                    var
                    algorithm = f_714_13451_13480(f_714_13451_13462(segments, 0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13501, 13567);

                    var
                    writer = f_714_13514_13566(encoding, algorithm, length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13585, 13700);
                        foreach (var segment in f_714_13609_13617_I(segments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(714, 13585, 13700);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13659, 13681);

                            f_714_13659_13680(segment, writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(714, 13585, 13700);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(714, 1, 116);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(714, 1, 116);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13720, 13737);

                    f_714_13720_13736(
                                    segments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 13755, 13791);

                    f_714_13755_13790(segments, f_714_13768_13789(writer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(714, 13326, 13806);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(714, 13024, 13817);

                int
                f_714_13155_13214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, out int
                length, out int
                size)
                {
                    ComputeLengthAndStorageSize((System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.SourceText>)segments, out length, out size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13155, 13214);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_13396_13407(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 13396, 13407);
                    return return_v;
                }


                System.Text.Encoding?
                f_714_13396_13416(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 13396, 13416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_13451_13462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 13451, 13462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_714_13451_13480(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 13451, 13480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceTextWriter
                f_714_13514_13566(System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, int
                length)
                {
                    var return_v = SourceTextWriter.Create(encoding, checksumAlgorithm, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13514, 13566);
                    return return_v;
                }


                int
                f_714_13659_13680(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceTextWriter
                textWriter)
                {
                    this_param.Write((System.IO.TextWriter)textWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13659, 13680);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                f_714_13609_13617_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13609, 13617);
                    return return_v;
                }


                int
                f_714_13720_13736(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13720, 13736);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_714_13768_13789(Microsoft.CodeAnalysis.Text.SourceTextWriter
                this_param)
                {
                    var return_v = this_param.ToSourceText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13768, 13789);
                    return return_v;
                }


                int
                f_714_13755_13790(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 13755, 13790);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(714, 13024, 13817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 13024, 13817);
            }
        }

        static CompositeText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(714, 602, 13824);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6789, 6830);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 6860, 6903);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 7666, 7705);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 7908, 7962);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(714, 11975, 12081);
            s_uniqueSourcesPool = f_714_12010_12081(() => new HashSet<SourceText>(), 5); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(714, 602, 13824);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(714, 602, 13824);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(714, 602, 13824);

        bool
        f_714_1125_1151_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 1125, 1151);
            return return_v;
        }


        static int
        f_714_1112_1152(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 1112, 1152);
            return 0;
        }


        static int
        f_714_1241_1309(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.SourceText>
        segments, out int
        length, out int
        size)
        {
            ComputeLengthAndStorageSize((System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.SourceText>)segments, out length, out size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 1241, 1309);
            return 0;
        }


        static int
        f_714_1432_1454(int[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 1432, 1454);
            return return_v;
        }


        static int
        f_714_1549_1568(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(714, 1549, 1568);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        f_714_1050_1086_C(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(714, 912, 1595);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>>
        f_714_12010_12081(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.SourceText>>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(714, 12010, 12081);
            return return_v;
        }

    }
}
