// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Roslyn.Utilities
{
    internal static class TextChangeRangeExtensions
    {
        public static TextChangeRange? Accumulate(this TextChangeRange? accumulatedTextChangeSoFar, IEnumerable<TextChangeRange> changesInNextVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(389, 524, 5540);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 691, 805) || true) && (!f_389_696_722(changesInNextVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 691, 805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 756, 790);

                    return accumulatedTextChangeSoFar;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 691, 805);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 1239, 1302);

                var
                newChange = TextChangeRange.Collapse(changesInNextVersion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 1388, 1492) || true) && (accumulatedTextChangeSoFar == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 1388, 1492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 1460, 1477);

                    return newChange;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 1388, 1492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 1560, 1623);

                var
                currentStart = accumulatedTextChangeSoFar.Value.Span.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 1637, 1699);

                var
                currentOldEnd = accumulatedTextChangeSoFar.Value.Span.End
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 1713, 1822);

                var
                currentNewEnd = accumulatedTextChangeSoFar.Value.Span.Start + accumulatedTextChangeSoFar.Value.NewLength
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 3573, 3697) || true) && (newChange.Span.Start < currentStart)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 3573, 3697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 3646, 3682);

                    currentStart = newChange.Span.Start;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 3573, 3697);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 4012, 5406) || true) && (currentNewEnd > newChange.Span.End)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 4012, 5406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 4551, 4627);

                    currentNewEnd = currentNewEnd + newChange.NewLength - newChange.Span.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 4012, 5406);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 4012, 5406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 5247, 5314);

                    currentOldEnd = currentOldEnd + newChange.Span.End - currentNewEnd;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 5332, 5391);

                    currentNewEnd = newChange.Span.Start + newChange.NewLength;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 4012, 5406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 5422, 5529);

                return f_389_5429_5528(TextSpan.FromBounds(currentStart, currentOldEnd), currentNewEnd - currentStart);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(389, 524, 5540);

                bool
                f_389_696_722(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Text.TextChangeRange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 696, 722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_389_5429_5528(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 5429, 5528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 524, 5540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 524, 5540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TextChangeRange ToTextChangeRange(this TextChange textChange)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(389, 5552, 5740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 5652, 5729);

                return f_389_5659_5728(textChange.Span, f_389_5696_5722_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(textChange.NewText, 389, 5696, 5722)?.Length) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(389, 5696, 5727) ?? 0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(389, 5552, 5740);

                int?
                f_389_5696_5722_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(389, 5696, 5722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_389_5659_5728(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 5659, 5728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 5552, 5740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 5552, 5740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TextChangeRange> Merge(ImmutableArray<TextChangeRange> oldChanges, ImmutableArray<TextChangeRange> newChanges)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(389, 6320, 20196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6595, 6714) || true) && (oldChanges.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 6595, 6714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6651, 6699);

                    throw f_389_6657_6698(nameof(oldChanges));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 6595, 6714);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6730, 6849) || true) && (newChanges.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 6730, 6849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6786, 6834);

                    throw f_389_6792_6833(nameof(newChanges));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 6730, 6849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6865, 6923);

                var
                builder = f_389_6879_6922()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6939, 6969);

                var
                oldChange = oldChanges[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 6983, 7038);

                var
                newChange = f_389_6999_7037(newChanges[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 7054, 7071);

                var
                oldIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 7085, 7102);

                var
                newIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 7328, 7345);

                var
                oldDelta = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 7853, 16830) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 7853, 16830);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 7898, 16815) || true) && (oldChange.Span.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(389, 7902, 7956) && oldChange.NewLength == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 7898, 16815);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8110, 8179) || true) && (f_389_8114_8135())
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8110, 8179);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8137, 8146);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8110, 8179);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8110, 8179);
                                DynAbs.Tracing.TraceSender.TraceBreak(389, 8173, 8179);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8110, 8179);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 7898, 16815);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 7898, 16815);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8221, 16815) || true) && (newChange.SpanLength == 0 && (DynAbs.Tracing.TraceSender.Expression_True(389, 8225, 8278) && newChange.NewLength == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8221, 16815);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8432, 8501) || true) && (f_389_8436_8457())
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8432, 8501);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8459, 8468);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8432, 8501);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8432, 8501);
                                    DynAbs.Tracing.TraceSender.TraceBreak(389, 8495, 8501);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8432, 8501);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8221, 16815);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8221, 16815);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8543, 16815) || true) && (newChange.SpanEnd <= oldChange.Span.Start + oldDelta)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8543, 16815);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8826, 8878);

                                    f_389_8826_8877(builder, oldDelta, newChange);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8900, 8969) || true) && (f_389_8904_8925())
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8900, 8969);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 8927, 8936);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8900, 8969);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8900, 8969);
                                        DynAbs.Tracing.TraceSender.TraceBreak(389, 8963, 8969);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8900, 8969);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8543, 16815);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 8543, 16815);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 9011, 16815) || true) && (newChange.SpanStart >= oldChange.NewEnd() + oldDelta)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 9011, 16815);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 9293, 9348);

                                        f_389_9293_9347(builder, ref oldDelta, oldChange);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 9370, 9439) || true) && (f_389_9374_9395())
                                        )
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 9370, 9439);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 9397, 9406);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 9370, 9439);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 9370, 9439);
                                            DynAbs.Tracing.TraceSender.TraceBreak(389, 9433, 9439);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 9370, 9439);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 9011, 16815);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 9011, 16815);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 9481, 16815) || true) && (newChange.SpanStart < oldChange.Span.Start + oldDelta)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 9481, 16815);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 10512, 10597);

                                            var
                                            newChangeLeadingDeletion = oldChange.Span.Start + oldDelta - newChange.SpanStart
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 10619, 10746);

                                            f_389_10619_10745(builder, oldDelta, f_389_10660_10744(newChange.SpanStart, newChangeLeadingDeletion, newLength: 0));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 10768, 10907);

                                            newChange = f_389_10780_10906(oldChange.Span.Start + oldDelta, newChange.SpanLength - newChangeLeadingDeletion, newChange.NewLength);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 10929, 10938);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 9481, 16815);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 9481, 16815);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 10980, 16815) || true) && (newChange.SpanStart > oldChange.Span.Start + oldDelta)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 10980, 16815);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 11719, 11807);

                                                var
                                                oldChangeLeadingInsertion = newChange.SpanStart - (oldChange.Span.Start + oldDelta)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 11940, 12030);

                                                var
                                                oldChangeLeadingDeletion = f_389_11971_12029(oldChange.Span.Length, oldChangeLeadingInsertion)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 12052, 12206);

                                                f_389_12052_12205(builder, ref oldDelta, f_389_12096_12204(f_389_12116_12176(oldChange.Span.Start, oldChangeLeadingDeletion), oldChangeLeadingInsertion));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 12228, 12405);

                                                oldChange = f_389_12240_12404(f_389_12260_12354(newChange.SpanStart - oldDelta, oldChange.Span.Length - oldChangeLeadingDeletion), oldChange.NewLength - oldChangeLeadingInsertion);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 12427, 12436);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 10980, 16815);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 10980, 16815);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 12593, 12662);

                                                f_389_12593_12661(newChange.SpanStart == oldChange.Span.Start + oldDelta);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 12686, 16796) || true) && (newChange.SpanLength <= oldChange.NewLength)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 12686, 16796);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 14035, 14127);

                                                    oldChange = f_389_14047_14126(oldChange.Span, oldChange.NewLength - newChange.SpanLength);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 14295, 14338);

                                                    oldDelta = oldDelta + newChange.SpanLength;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 14470, 14561);

                                                    newChange = f_389_14482_14560(newChange.SpanEnd, spanLength: 0, newChange.NewLength);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 14587, 14639);

                                                    f_389_14587_14638(builder, oldDelta, newChange);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 14665, 14738) || true) && (f_389_14669_14690())
                                                    )
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 14665, 14738);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 14692, 14701);

                                                        continue;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 14665, 14738);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 14665, 14738);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(389, 14732, 14738);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 14665, 14738);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 12686, 16796);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 12686, 16796);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 16366, 16432);

                                                    oldDelta = oldDelta - oldChange.Span.Length + oldChange.NewLength;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 16460, 16545);

                                                    var
                                                    newDeletion = newChange.SpanLength + oldChange.Span.Length - oldChange.NewLength
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 16571, 16674);

                                                    newChange = f_389_16583_16673(oldChange.Span.Start + oldDelta, newDeletion, newChange.NewLength);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 16700, 16773) || true) && (f_389_16704_16725())
                                                    )
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 16700, 16773);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 16727, 16736);

                                                        continue;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 16700, 16773);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 16700, 16773);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(389, 16767, 16773);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 16700, 16773);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 12686, 16796);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 10980, 16815);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 9481, 16815);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 9011, 16815);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8543, 16815);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 8221, 16815);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 7898, 16815);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 7853, 16830);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(389, 7853, 16830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(389, 7853, 16830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 16950, 17183);

                switch (oldIndex == oldChanges.Length, newIndex == newChanges.Length)
                {

                    case (true, true):
                    case (false, false):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 16950, 17183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17130, 17168);

                        throw f_389_17136_17167();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 16950, 17183);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17199, 17378) || true) && (oldIndex < oldChanges.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 17199, 17378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17268, 17323);

                        f_389_17268_17322(builder, ref oldDelta, oldChange);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17341, 17363);

                        f_389_17341_17362();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 17199, 17378);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(389, 17199, 17378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(389, 17199, 17378);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17394, 17570) || true) && (newIndex < newChanges.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 17394, 17570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17463, 17515);

                        f_389_17463_17514(builder, oldDelta, newChange);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17533, 17555);

                        f_389_17533_17554();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(389, 17394, 17570);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(389, 17394, 17570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(389, 17394, 17570);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17586, 17622);

                return f_389_17593_17621(builder);

                bool tryGetNextOldChange()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(389, 17638, 18038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17697, 17708);

                        oldIndex++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17726, 18023) || true) && (oldIndex < oldChanges.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 17726, 18023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17800, 17833);

                            oldChange = oldChanges[oldIndex];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17855, 17867);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 17726, 18023);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 17726, 18023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17949, 17969);

                            oldChange = default;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 17991, 18004);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 17726, 18023);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(389, 17638, 18038);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 17638, 18038);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 17638, 18038);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool tryGetNextNewChange()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(389, 18054, 18479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18113, 18124);

                        newIndex++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18142, 18464) || true) && (newIndex < newChanges.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 18142, 18464);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18216, 18274);

                            newChange = f_389_18228_18273(newChanges[newIndex]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18296, 18308);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 18142, 18464);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 18142, 18464);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18390, 18410);

                            newChange = default;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18432, 18445);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 18142, 18464);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(389, 18054, 18479);

                        Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                        f_389_18228_18273(Microsoft.CodeAnalysis.Text.TextChangeRange
                        range)
                        {
                            var return_v = new Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange(range);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 18228, 18273);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 18054, 18479);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 18054, 18479);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static void addAndAdjustOldDelta(ArrayBuilder<TextChangeRange> builder, ref int oldDelta, TextChangeRange oldChange)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(389, 18495, 18863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18740, 18806);

                        oldDelta = oldDelta - oldChange.Span.Length + oldChange.NewLength;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 18824, 18848);

                        f_389_18824_18847(builder, oldChange);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(389, 18495, 18863);

                        int
                        f_389_18824_18847(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                        builder, Microsoft.CodeAnalysis.Text.TextChangeRange
                        change)
                        {
                            add(builder, change);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 18824, 18847);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 18495, 18863);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 18495, 18863);
                    }
                }

                static void adjustAndAddNewChange(ArrayBuilder<TextChangeRange> builder, int oldDelta, UnadjustedNewChange newChange)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(389, 18879, 19328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19190, 19313);

                        f_389_19190_19312(builder, f_389_19203_19311(f_389_19223_19289(newChange.SpanStart - oldDelta, newChange.SpanLength), newChange.NewLength));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(389, 18879, 19328);

                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_389_19223_19289(int
                        start, int
                        length)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 19223, 19289);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextChangeRange
                        f_389_19203_19311(Microsoft.CodeAnalysis.Text.TextSpan
                        span, int
                        newLength)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 19203, 19311);
                            return return_v;
                        }


                        int
                        f_389_19190_19312(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                        builder, Microsoft.CodeAnalysis.Text.TextChangeRange
                        change)
                        {
                            add(builder, change);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 19190, 19312);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 18879, 19328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 18879, 19328);
                    }
                }

                static void add(ArrayBuilder<TextChangeRange> builder, TextChangeRange change)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(389, 19344, 20185);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19455, 20130) || true) && (f_389_19459_19472(builder) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 19455, 20130);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19518, 19541);

                            var
                            last = builder[^1]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19563, 20109) || true) && (last.Span.End == change.Span.Start)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 19563, 20109);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19723, 19862);

                                builder[^1] = f_389_19737_19861(f_389_19757_19825(last.Span.Start, last.Span.Length + change.Span.Length), last.NewLength + change.NewLength);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19888, 19895);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 19563, 20109);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 19563, 20109);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 19945, 20109) || true) && (last.Span.End > change.Span.Start)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(389, 19945, 20109);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 20032, 20086);

                                    throw f_389_20038_20085(nameof(change));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(389, 19945, 20109);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(389, 19563, 20109);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(389, 19455, 20130);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 20150, 20170);

                        f_389_20150_20169(
                                        builder, change);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(389, 19344, 20185);

                        int
                        f_389_19459_19472(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(389, 19459, 19472);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_389_19757_19825(int
                        start, int
                        length)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 19757, 19825);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextChangeRange
                        f_389_19737_19861(Microsoft.CodeAnalysis.Text.TextSpan
                        span, int
                        newLength)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 19737, 19861);
                            return return_v;
                        }


                        System.ArgumentOutOfRangeException
                        f_389_20038_20085(string
                        paramName)
                        {
                            var return_v = new System.ArgumentOutOfRangeException(paramName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 20038, 20085);
                            return return_v;
                        }


                        int
                        f_389_20150_20169(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                        this_param, Microsoft.CodeAnalysis.Text.TextChangeRange
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 20150, 20169);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 19344, 20185);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 19344, 20185);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(389, 6320, 20196);

                System.ArgumentException
                f_389_6657_6698(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 6657, 6698);
                    return return_v;
                }


                System.ArgumentException
                f_389_6792_6833(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 6792, 6833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_389_6879_6922()
                {
                    var return_v = ArrayBuilder<TextChangeRange>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 6879, 6922);
                    return return_v;
                }


                Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                f_389_6999_7037(Microsoft.CodeAnalysis.Text.TextChangeRange
                range)
                {
                    var return_v = new Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange(range);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 6999, 7037);
                    return return_v;
                }


                bool
                f_389_8114_8135()
                {
                    var return_v = tryGetNextOldChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 8114, 8135);
                    return return_v;
                }


                bool
                f_389_8436_8457()
                {
                    var return_v = tryGetNextNewChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 8436, 8457);
                    return return_v;
                }


                int
                f_389_8826_8877(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, int
                oldDelta, Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                newChange)
                {
                    adjustAndAddNewChange(builder, oldDelta, newChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 8826, 8877);
                    return 0;
                }


                bool
                f_389_8904_8925()
                {
                    var return_v = tryGetNextNewChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 8904, 8925);
                    return return_v;
                }


                int
                f_389_9293_9347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, ref int
                oldDelta, Microsoft.CodeAnalysis.Text.TextChangeRange
                oldChange)
                {
                    addAndAdjustOldDelta(builder, ref oldDelta, oldChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 9293, 9347);
                    return 0;
                }


                bool
                f_389_9374_9395()
                {
                    var return_v = tryGetNextOldChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 9374, 9395);
                    return return_v;
                }


                Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                f_389_10660_10744(int
                spanStart, int
                spanLength, int
                newLength)
                {
                    var return_v = new Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange(spanStart, spanLength, newLength: newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 10660, 10744);
                    return return_v;
                }


                int
                f_389_10619_10745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, int
                oldDelta, Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                newChange)
                {
                    adjustAndAddNewChange(builder, oldDelta, newChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 10619, 10745);
                    return 0;
                }


                Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                f_389_10780_10906(int
                spanStart, int
                spanLength, int
                newLength)
                {
                    var return_v = new Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange(spanStart, spanLength, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 10780, 10906);
                    return return_v;
                }


                int
                f_389_11971_12029(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 11971, 12029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_389_12116_12176(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 12116, 12176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_389_12096_12204(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 12096, 12204);
                    return return_v;
                }


                int
                f_389_12052_12205(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, ref int
                oldDelta, Microsoft.CodeAnalysis.Text.TextChangeRange
                oldChange)
                {
                    addAndAdjustOldDelta(builder, ref oldDelta, oldChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 12052, 12205);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_389_12260_12354(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 12260, 12354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_389_12240_12404(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 12240, 12404);
                    return return_v;
                }


                int
                f_389_12593_12661(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 12593, 12661);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_389_14047_14126(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 14047, 14126);
                    return return_v;
                }


                Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                f_389_14482_14560(int
                spanStart, int
                spanLength, int
                newLength)
                {
                    var return_v = new Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange(spanStart, spanLength: spanLength, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 14482, 14560);
                    return return_v;
                }


                int
                f_389_14587_14638(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, int
                oldDelta, Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                newChange)
                {
                    adjustAndAddNewChange(builder, oldDelta, newChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 14587, 14638);
                    return 0;
                }


                bool
                f_389_14669_14690()
                {
                    var return_v = tryGetNextNewChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 14669, 14690);
                    return return_v;
                }


                Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                f_389_16583_16673(int
                spanStart, int
                spanLength, int
                newLength)
                {
                    var return_v = new Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange(spanStart, spanLength, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 16583, 16673);
                    return return_v;
                }


                bool
                f_389_16704_16725()
                {
                    var return_v = tryGetNextOldChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 16704, 16725);
                    return return_v;
                }


                System.InvalidOperationException
                f_389_17136_17167()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 17136, 17167);
                    return return_v;
                }


                int
                f_389_17268_17322(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, ref int
                oldDelta, Microsoft.CodeAnalysis.Text.TextChangeRange
                oldChange)
                {
                    addAndAdjustOldDelta(builder, ref oldDelta, oldChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 17268, 17322);
                    return 0;
                }


                bool
                f_389_17341_17362()
                {
                    var return_v = tryGetNextOldChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 17341, 17362);
                    return return_v;
                }


                int
                f_389_17463_17514(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                builder, int
                oldDelta, Roslyn.Utilities.TextChangeRangeExtensions.UnadjustedNewChange
                newChange)
                {
                    adjustAndAddNewChange(builder, oldDelta, newChange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 17463, 17514);
                    return 0;
                }


                bool
                f_389_17533_17554()
                {
                    var return_v = tryGetNextNewChange();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 17533, 17554);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_389_17593_17621(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(389, 17593, 17621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 6320, 20196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 6320, 20196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly struct UnadjustedNewChange
        {

            public readonly int SpanStart { get; }

            public readonly int SpanLength { get; }

            public readonly int NewLength { get; }

            public int SpanEnd
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(389, 21214, 21239);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 21217, 21239);
                        return SpanStart + SpanLength; DynAbs.Tracing.TraceSender.TraceExitMethod(389, 21214, 21239);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 21214, 21239);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 21214, 21239);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public UnadjustedNewChange(int spanStart, int spanLength, int newLength)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(389, 21256, 21480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 21361, 21383);

                    SpanStart = spanStart;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 21401, 21425);

                    SpanLength = spanLength;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 21443, 21465);

                    NewLength = newLength;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(389, 21256, 21480);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 21256, 21480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 21256, 21480);
                }
            }

            public UnadjustedNewChange(TextChangeRange range)
            : this(f_389_21570_21586_C(range.Span.Start), range.Span.Length, range.NewLength)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(389, 21496, 21653);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(389, 21496, 21653);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 21496, 21653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 21496, 21653);
                }
            }
            static UnadjustedNewChange()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(389, 20968, 21664);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(389, 20968, 21664);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 20968, 21664);
            }

            static int
            f_389_21570_21586_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(389, 21496, 21653);
                return return_v;
            }

        }

        private static int NewEnd(this TextChangeRange range)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(389, 21730, 21767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(389, 21733, 21767);
                return range.Span.Start + range.NewLength; DynAbs.Tracing.TraceSender.TraceExitMethod(389, 21730, 21767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(389, 21730, 21767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 21730, 21767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TextChangeRangeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(389, 460, 21775);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(389, 460, 21775);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(389, 460, 21775);
        }

    }
}
