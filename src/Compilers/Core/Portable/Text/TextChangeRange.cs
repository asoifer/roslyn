// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{

    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    public readonly struct TextChangeRange : IEquatable<TextChangeRange>
    {

        public TextSpan Span { get; }

        public int NewLength { get; }

        internal int NewEnd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(731, 931, 956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 934, 956);
                    return Span.Start + NewLength; DynAbs.Tracing.TraceSender.TraceExitMethod(731, 931, 956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 931, 956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 931, 956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextChangeRange(TextSpan span, int newLength)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(731, 1177, 1484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 1276, 1399) || true) && (newLength < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(731, 1276, 1399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 1327, 1384);

                    throw f_731_1333_1383(nameof(newLength));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(731, 1276, 1399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 1415, 1432);

                this.Span = span;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 1446, 1473);

                this.NewLength = newLength;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(731, 1177, 1484);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 1177, 1484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 1177, 1484);
            }
        }

        public bool Equals(TextChangeRange other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(731, 1627, 1806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 1693, 1795);

                return
                                other.Span == this.Span && (DynAbs.Tracing.TraceSender.Expression_True(731, 1717, 1794) && other.NewLength == this.NewLength);
                DynAbs.Tracing.TraceSender.TraceExitMethod(731, 1627, 1806);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 1627, 1806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 1627, 1806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(731, 1949, 2078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 2014, 2067);

                return obj is TextChangeRange range && (DynAbs.Tracing.TraceSender.Expression_True(731, 2021, 2066) && Equals(range));
                DynAbs.Tracing.TraceSender.TraceExitMethod(731, 1949, 2078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 1949, 2078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 1949, 2078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(731, 2257, 2387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 2315, 2376);

                return f_731_2322_2375(this.NewLength, this.Span.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(731, 2257, 2387);

                int
                f_731_2322_2375(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(731, 2322, 2375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 2257, 2387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 2257, 2387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(TextChangeRange left, TextChangeRange right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(731, 2530, 2667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 2630, 2656);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(731, 2530, 2667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 2530, 2667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 2530, 2667);
            }
        }

        public static bool operator !=(TextChangeRange left, TextChangeRange right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(731, 2815, 2950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 2915, 2939);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(731, 2815, 2950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 2815, 2950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 2815, 2950);
            }
        }

        public static IReadOnlyList<TextChangeRange> NoChanges
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(731, 3102, 3164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3105, 3164);
                    return f_731_3105_3164(); DynAbs.Tracing.TraceSender.TraceExitMethod(731, 3102, 3164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 3102, 3164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 3102, 3164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static TextChangeRange Collapse(IEnumerable<TextChangeRange> changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(731, 3402, 4326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3503, 3516);

                var
                diff = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3530, 3555);

                var
                start = int.MaxValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3569, 3581);

                var
                end = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3597, 3986);
                    foreach (var change in f_731_3620_3627_I(changes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(731, 3597, 3986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3661, 3707);

                        diff += change.NewLength - change.Span.Length;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3727, 3843) || true) && (change.Span.Start < start)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(731, 3727, 3843);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3798, 3824);

                            start = change.Span.Start;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(731, 3727, 3843);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3863, 3971) || true) && (change.Span.End > end)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(731, 3863, 3971);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 3930, 3952);

                            end = change.Span.End;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(731, 3863, 3971);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(731, 3597, 3986);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(731, 1, 390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(731, 1, 390);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 4002, 4141) || true) && (start > end)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(731, 4002, 4141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 4094, 4126);

                    return default(TextChangeRange);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(731, 4002, 4141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 4157, 4204);

                var
                combined = TextSpan.FromBounds(start, end)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 4218, 4254);

                var
                newLen = combined.Length + diff
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 4270, 4315);

                return f_731_4277_4314(combined, newLen);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(731, 3402, 4326);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_731_3620_3627_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(731, 3620, 3627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_731_4277_4314(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(731, 4277, 4314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 3402, 4326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 3402, 4326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(731, 4338, 4495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(731, 4398, 4484);

                return $"new TextChangeRange(new TextSpan({Span.Start}, {Span.Length}), {NewLength})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(731, 4338, 4495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(731, 4338, 4495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 4338, 4495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TextChangeRange()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(731, 447, 4502);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(731, 447, 4502);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(731, 447, 4502);
        }

        static System.ArgumentOutOfRangeException
        f_731_1333_1383(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(731, 1333, 1383);
            return return_v;
        }


        static System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
        f_731_3105_3164()
        {
            var return_v = SpecializedCollections.EmptyReadOnlyList<TextChangeRange>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(731, 3105, 3164);
            return return_v;
        }

    }
}
