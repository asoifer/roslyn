// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal class SequencePointList
    {
        private readonly SyntaxTree _tree;

        private readonly OffsetAndSpan[] _points;

        private SequencePointList _next;

        private static readonly SequencePointList s_empty;

        private SequencePointList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(82, 1196, 1298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 880, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 929, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 973, 978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 1248, 1287);

                _points = f_82_1258_1286();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(82, 1196, 1298);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 1196, 1298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 1196, 1298);
            }
        }

        private SequencePointList(SyntaxTree tree, OffsetAndSpan[] points)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(82, 1390, 1536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 880, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 929, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 973, 978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 1481, 1494);

                _tree = tree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 1508, 1525);

                _points = points;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(82, 1390, 1536);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 1390, 1536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 1390, 1536);
            }
        }

        public static SequencePointList Create(ArrayBuilder<RawSequencePoint> seqPointBuilder, ILBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(82, 1789, 3036);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 1919, 2031) || true) && (f_82_1923_1944(seqPointBuilder) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 1919, 2031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 1983, 2016);

                    return SequencePointList.s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(82, 1919, 2031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2047, 2094);

                SequencePointList
                first = null
                ,
                current = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2108, 2148);

                int
                totalPoints = f_82_2126_2147(seqPointBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2162, 2175);

                int
                last = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2200, 2205);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2191, 2996) || true) && (i <= totalPoints)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2225, 2228)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(82, 2191, 2996))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 2191, 2996);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2262, 2981) || true) && (i == totalPoints || (DynAbs.Tracing.TraceSender.Expression_False(82, 2266, 2352) || seqPointBuilder[i].SyntaxTree != seqPointBuilder[i - 1].SyntaxTree))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 2262, 2981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2436, 2573);

                            SequencePointList
                            next = f_82_2461_2572(seqPointBuilder[i - 1].SyntaxTree, f_82_2518_2571(seqPointBuilder, last, i - last, builder))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2595, 2604);

                            last = i;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2687, 2962) || true) && (current == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 2687, 2962);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2756, 2779);

                                first = current = next;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(82, 2687, 2962);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 2687, 2962);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2877, 2898);

                                current._next = next;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 2924, 2939);

                                current = next;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(82, 2687, 2962);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(82, 2262, 2981);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(82, 1, 806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(82, 1, 806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3012, 3025);

                return first;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(82, 1789, 3036);

                int
                f_82_1923_1944(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 1923, 1944);
                    return return_v;
                }


                int
                f_82_2126_2147(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 2126, 2147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                f_82_2518_2571(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                seqPointBuilder, int
                start, int
                length, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = GetSubArray(seqPointBuilder, start, length, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 2518, 2571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SequencePointList
                f_82_2461_2572(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                points)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SequencePointList(tree, points);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 2461, 2572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 1789, 3036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 1789, 3036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(82, 3092, 3187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3128, 3172);

                    return _next == null && (DynAbs.Tracing.TraceSender.Expression_True(82, 3135, 3171) && f_82_3152_3166(_points) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(82, 3092, 3187);

                    int
                    f_82_3152_3166(Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 3152, 3166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 3048, 3198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 3048, 3198);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static OffsetAndSpan[] GetSubArray(ArrayBuilder<RawSequencePoint> seqPointBuilder, int start, int length, ILBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(82, 3210, 3807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3367, 3418);

                OffsetAndSpan[]
                result = new OffsetAndSpan[length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3441, 3446);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3432, 3766) || true) && (i < f_82_3452_3465(result))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3467, 3470)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(82, 3432, 3766))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 3432, 3766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3504, 3556);

                        RawSequencePoint
                        point = f_82_3529_3555(seqPointBuilder, i + start)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3574, 3635);

                        int
                        ilOffset = f_82_3589_3634(builder, point.ILMarker)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3653, 3681);

                        f_82_3653_3680(ilOffset >= 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3699, 3751);

                        result[i] = f_82_3711_3750(ilOffset, point.Span);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(82, 1, 335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(82, 1, 335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 3782, 3796);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(82, 3210, 3807);

                int
                f_82_3452_3465(Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 3452, 3465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.RawSequencePoint
                f_82_3529_3555(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 3529, 3555);
                    return return_v;
                }


                int
                f_82_3589_3634(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                ilMarker)
                {
                    var return_v = this_param.GetILOffsetFromMarker(ilMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 3589, 3634);
                    return return_v;
                }


                int
                f_82_3653_3680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 3653, 3680);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan
                f_82_3711_3750(int
                offset, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan(offset, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 3711, 3750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 3210, 3807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 3210, 3807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetSequencePoints(
                    DebugDocumentProvider documentProvider,
                    ArrayBuilder<Cci.SequencePoint> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(82, 4247, 9337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4409, 4439);

                bool
                lastPathIsMapped = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4453, 4476);

                string
                lastPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4490, 4539);

                Cci.DebugSourceDocument
                lastDebugDocument = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4555, 4618);

                FileLinePositionSpan?
                firstReal = f_82_4589_4617(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4632, 4711) || true) && (f_82_4636_4655_M(!firstReal.HasValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 4632, 4711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4689, 4696);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(82, 4632, 4711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4725, 4757);

                lastPath = firstReal.Value.Path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4771, 4820);

                lastPathIsMapped = firstReal.Value.HasMappedPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4834, 4938);

                lastDebugDocument = f_82_4854_4937(documentProvider, lastPath, basePath: (DynAbs.Tracing.TraceSender.Conditional_F1(82, 4891, 4907) || ((lastPathIsMapped && DynAbs.Tracing.TraceSender.Conditional_F2(82, 4910, 4929)) || DynAbs.Tracing.TraceSender.Conditional_F3(82, 4932, 4936))) ? f_82_4910_4929(this._tree) : null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 4954, 4987);

                SequencePointList
                current = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5001, 9326) || true) && (current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 5001, 9326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5057, 5096);

                        SyntaxTree
                        currentTree = current._tree
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5116, 9267);
                            foreach (var offsetAndSpan in f_82_5146_5161_I(current._points))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 5116, 9267);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5203, 5238);

                                TextSpan
                                span = offsetAndSpan.Span
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5574, 5639);

                                bool
                                isHidden = span == RawSequencePoint.HiddenSequencePointSpan
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5661, 5713);

                                FileLinePositionSpan
                                fileLinePositionSpan = default
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5735, 5907) || true) && (!isHidden)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 5735, 5907);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5798, 5884);

                                    fileLinePositionSpan = f_82_5821_5883(currentTree, span, out isHidden);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(82, 5735, 5907);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5931, 9248) || true) && (isHidden)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 5931, 9248);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 5993, 6223) || true) && (lastPath == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 5993, 6223);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 6071, 6103);

                                        lastPath = f_82_6082_6102(currentTree);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 6133, 6196);

                                        lastDebugDocument = f_82_6153_6195(documentProvider, lastPath, basePath: null);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 5993, 6223);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 6251, 6758) || true) && (lastDebugDocument != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 6251, 6758);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 6338, 6731);

                                        f_82_6338_6730(builder, f_82_6350_6729(lastDebugDocument, offset: offsetAndSpan.Offset, startLine: Cci.SequencePoint.HiddenLine, startColumn: 0, endLine: Cci.SequencePoint.HiddenLine, endColumn: 0));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 6251, 6758);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(82, 5931, 9248);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 5931, 9248);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 6856, 7296) || true) && (lastPath != fileLinePositionSpan.Path || (DynAbs.Tracing.TraceSender.Expression_False(82, 6860, 6955) || lastPathIsMapped != fileLinePositionSpan.HasMappedPath))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 6856, 7296);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7013, 7050);

                                        lastPath = fileLinePositionSpan.Path;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7080, 7134);

                                        lastPathIsMapped = fileLinePositionSpan.HasMappedPath;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7164, 7269);

                                        lastDebugDocument = f_82_7184_7268(documentProvider, lastPath, basePath: (DynAbs.Tracing.TraceSender.Conditional_F1(82, 7221, 7237) || ((lastPathIsMapped && DynAbs.Tracing.TraceSender.Conditional_F2(82, 7240, 7260)) || DynAbs.Tracing.TraceSender.Conditional_F3(82, 7263, 7267))) ? f_82_7240_7260(currentTree) : null);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 6856, 7296);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7324, 9225) || true) && (lastDebugDocument != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 7324, 9225);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7411, 7533);

                                        int
                                        startLine = (DynAbs.Tracing.TraceSender.Conditional_F1(82, 7427, 7478) || (((fileLinePositionSpan.StartLinePosition.Line == -1) && DynAbs.Tracing.TraceSender.Conditional_F2(82, 7481, 7482)) || DynAbs.Tracing.TraceSender.Conditional_F3(82, 7485, 7532))) ? 0 : fileLinePositionSpan.StartLinePosition.Line + 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7563, 7679);

                                        int
                                        endLine = (DynAbs.Tracing.TraceSender.Conditional_F1(82, 7577, 7626) || (((fileLinePositionSpan.EndLinePosition.Line == -1) && DynAbs.Tracing.TraceSender.Conditional_F2(82, 7629, 7630)) || DynAbs.Tracing.TraceSender.Conditional_F3(82, 7633, 7678))) ? 0 : fileLinePositionSpan.EndLinePosition.Line + 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7709, 7780);

                                        int
                                        startColumn = fileLinePositionSpan.StartLinePosition.Character + 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 7810, 7877);

                                        int
                                        endColumn = fileLinePositionSpan.EndLinePosition.Character + 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 8310, 8352);

                                        const int
                                        MaxColumn = ushort.MaxValue - 1
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 8384, 8573) || true) && (startColumn > MaxColumn)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 8384, 8573);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 8477, 8542);

                                            startColumn = (DynAbs.Tracing.TraceSender.Conditional_F1(82, 8491, 8513) || (((startLine == endLine) && DynAbs.Tracing.TraceSender.Conditional_F2(82, 8516, 8529)) || DynAbs.Tracing.TraceSender.Conditional_F3(82, 8532, 8541))) ? MaxColumn - 1 : MaxColumn;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(82, 8384, 8573);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 8605, 8749) || true) && (endColumn > MaxColumn)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 8605, 8749);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 8696, 8718);

                                            endColumn = MaxColumn;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(82, 8605, 8749);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 8781, 9198);

                                        f_82_8781_9197(
                                                                    builder, f_82_8793_9196(lastDebugDocument, offset: offsetAndSpan.Offset, startLine: startLine, startColumn: (ushort)startColumn, endLine: endLine, endColumn: (ushort)endColumn));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 7324, 9225);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(82, 5931, 9248);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(82, 5116, 9267);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(82, 1, 4152);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(82, 1, 4152);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9287, 9311);

                        current = current._next;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 5001, 9326);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(82, 5001, 9326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(82, 5001, 9326);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(82, 4247, 9337);

                Microsoft.CodeAnalysis.FileLinePositionSpan?
                f_82_4589_4617(Microsoft.CodeAnalysis.CodeGen.SequencePointList
                this_param)
                {
                    var return_v = this_param.FindFirstRealSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 4589, 4617);
                    return return_v;
                }


                bool
                f_82_4636_4655_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 4636, 4655);
                    return return_v;
                }


                string
                f_82_4910_4929(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 4910, 4929);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_82_4854_4937(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                this_param, string
                path, string?
                basePath)
                {
                    var return_v = this_param.Invoke(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 4854, 4937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_82_5821_5883(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, out bool
                isHiddenPosition)
                {
                    var return_v = this_param.GetMappedLineSpanAndVisibility(span, out isHiddenPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 5821, 5883);
                    return return_v;
                }


                string
                f_82_6082_6102(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 6082, 6102);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_82_6153_6195(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.Invoke(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 6153, 6195);
                    return return_v;
                }


                Microsoft.Cci.SequencePoint
                f_82_6350_6729(Microsoft.Cci.DebugSourceDocument
                document, int
                offset, int
                startLine, int
                startColumn, int
                endLine, int
                endColumn)
                {
                    var return_v = new Microsoft.Cci.SequencePoint(document, offset: offset, startLine: startLine, startColumn: (ushort)startColumn, endLine: endLine, endColumn: (ushort)endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 6350, 6729);
                    return return_v;
                }


                int
                f_82_6338_6730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.SequencePoint>
                this_param, Microsoft.Cci.SequencePoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 6338, 6730);
                    return 0;
                }


                string
                f_82_7240_7260(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(82, 7240, 7260);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_82_7184_7268(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                this_param, string
                path, string?
                basePath)
                {
                    var return_v = this_param.Invoke(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 7184, 7268);
                    return return_v;
                }


                Microsoft.Cci.SequencePoint
                f_82_8793_9196(Microsoft.Cci.DebugSourceDocument
                document, int
                offset, int
                startLine, int
                startColumn, int
                endLine, int
                endColumn)
                {
                    var return_v = new Microsoft.Cci.SequencePoint(document, offset: offset, startLine: startLine, startColumn: (ushort)startColumn, endLine: endLine, endColumn: (ushort)endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 8793, 9196);
                    return return_v;
                }


                int
                f_82_8781_9197(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.SequencePoint>
                this_param, Microsoft.Cci.SequencePoint
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 8781, 9197);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                f_82_5146_5161_I(Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 5146, 5161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 4247, 9337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 4247, 9337);
            }
        }

        private FileLinePositionSpan? FindFirstRealSequencePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(82, 9498, 10379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9581, 9614);

                SequencePointList
                current = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9630, 10340) || true) && (current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 9630, 10340);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9686, 10283);
                            foreach (var offsetAndSpan in f_82_9716_9731_I(current._points))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 9686, 10283);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9773, 9808);

                                TextSpan
                                span = offsetAndSpan.Span
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9830, 9895);

                                bool
                                isHidden = span == RawSequencePoint.HiddenSequencePointSpan
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9917, 10264) || true) && (!isHidden)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 9917, 10264);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 9980, 10089);

                                    FileLinePositionSpan
                                    fileLinePositionSpan = f_82_10024_10088(current._tree, span, out isHidden)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 10115, 10241) || true) && (!isHidden)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(82, 10115, 10241);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 10186, 10214);

                                        return fileLinePositionSpan;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 10115, 10241);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(82, 9917, 10264);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(82, 9686, 10283);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(82, 1, 598);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(82, 1, 598);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 10301, 10325);

                        current = current._next;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(82, 9630, 10340);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(82, 9630, 10340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(82, 9630, 10340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 10356, 10368);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(82, 9498, 10379);

                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_82_10024_10088(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, out bool
                isHiddenPosition)
                {
                    var return_v = this_param.GetMappedLineSpanAndVisibility(span, out isHiddenPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 10024, 10088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                f_82_9716_9731_I(Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 9716, 9731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 9498, 10379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 9498, 10379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct OffsetAndSpan
        {

            public readonly int Offset;

            public readonly TextSpan Span;

            public OffsetAndSpan(int offset, TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(82, 10658, 10809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 10738, 10759);

                    this.Offset = offset;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 10777, 10794);

                    this.Span = span;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(82, 10658, 10809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(82, 10658, 10809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 10658, 10809);
                }
            }
            static OffsetAndSpan()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(82, 10518, 10820);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(82, 10518, 10820);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 10518, 10820);
            }
        }

        static SequencePointList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(82, 803, 10827);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(82, 1096, 1129);
            s_empty = f_82_1106_1129(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(82, 803, 10827);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(82, 803, 10827);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(82, 803, 10827);

        static Microsoft.CodeAnalysis.CodeGen.SequencePointList
        f_82_1106_1129()
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.SequencePointList();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 1106, 1129);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.SequencePointList.OffsetAndSpan[]
        f_82_1258_1286()
        {
            var return_v = Array.Empty<OffsetAndSpan>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(82, 1258, 1286);
            return return_v;
        }

    }
}
