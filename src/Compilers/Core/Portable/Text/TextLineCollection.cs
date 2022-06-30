// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Text
{
    public abstract class TextLineCollection : IReadOnlyList<TextLine>
    {
        public abstract int Count { get; }

        /// <summary>
        /// Gets the <see cref="TextLine"/> item at the specified index.
        /// </summary>
        public abstract TextLine this[int index] { get; }

        public abstract int IndexOf(int position);

        public virtual TextLine GetLineFromPosition(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 1338, 1467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 1420, 1456);

                return f_733_1427_1455(this, f_733_1432_1454(this, position));
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 1338, 1467);

                int
                f_733_1432_1454(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.IndexOf(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 1432, 1454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_733_1427_1455(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(733, 1427, 1455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 1338, 1467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 1338, 1467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual LinePosition GetLinePosition(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 1612, 1824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 1694, 1735);

                var
                line = f_733_1705_1734(this, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 1749, 1813);

                return f_733_1756_1812(line.LineNumber, position - line.Start);
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 1612, 1824);

                Microsoft.CodeAnalysis.Text.TextLine
                f_733_1705_1734(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLineFromPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 1705, 1734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_733_1756_1812(int
                line, int
                character)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(line, character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 1756, 1812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 1612, 1824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 1612, 1824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public LinePositionSpan GetLinePositionSpan(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 1966, 2144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 2049, 2133);

                return f_733_2056_2132(f_733_2077_2104(this, span.Start), f_733_2106_2131(this, span.End));
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 1966, 2144);

                Microsoft.CodeAnalysis.Text.LinePosition
                f_733_2077_2104(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2077, 2104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_733_2106_2131(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2106, 2131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePositionSpan
                f_733_2056_2132(Microsoft.CodeAnalysis.Text.LinePosition
                start, Microsoft.CodeAnalysis.Text.LinePosition
                end)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePositionSpan(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2056, 2132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 1966, 2144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 1966, 2144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetPosition(LinePosition position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 2268, 2403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 2338, 2392);

                return this[position.Line].Start + position.Character;
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 2268, 2403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 2268, 2403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 2268, 2403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextSpan GetTextSpan(LinePositionSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 2543, 2704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 2618, 2693);

                return TextSpan.FromBounds(f_733_2645_2668(this, span.Start), f_733_2670_2691(this, span.End));
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 2543, 2704);

                int
                f_733_2645_2668(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, Microsoft.CodeAnalysis.Text.LinePosition
                position)
                {
                    var return_v = this_param.GetPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2645, 2668);
                    return return_v;
                }


                int
                f_733_2670_2691(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, Microsoft.CodeAnalysis.Text.LinePosition
                position)
                {
                    var return_v = this_param.GetPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2670, 2691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 2543, 2704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 2543, 2704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 2716, 2813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 2774, 2802);

                return f_733_2781_2801(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 2716, 2813);

                Microsoft.CodeAnalysis.Text.TextLineCollection.Enumerator
                f_733_2781_2801(Microsoft.CodeAnalysis.Text.TextLineCollection
                lines)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextLineCollection.Enumerator(lines);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2781, 2801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 2716, 2813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 2716, 2813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<TextLine> IEnumerable<TextLine>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 2825, 2948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 2909, 2937);

                return f_733_2916_2936(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 2825, 2948);

                Microsoft.CodeAnalysis.Text.TextLineCollection.Enumerator
                f_733_2916_2936(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 2916, 2936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 2825, 2948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 2825, 2948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 2960, 3063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3024, 3052);

                return f_733_3031_3051(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(733, 2960, 3063);

                Microsoft.CodeAnalysis.Text.TextLineCollection.Enumerator
                f_733_3031_3051(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 3031, 3051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 2960, 3063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 2960, 3063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
        public struct Enumerator : IEnumerator<TextLine>, IEnumerator
        {

            private readonly TextLineCollection _lines;

            private int _index;

            internal Enumerator(TextLineCollection lines, int index = -1)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(733, 3358, 3515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3452, 3467);

                    _lines = lines;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3485, 3500);

                    _index = index;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(733, 3358, 3515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 3358, 3515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 3358, 3515);
                }
            }

            public TextLine Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 3587, 3938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3631, 3648);

                        var
                        ndx = _index
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3670, 3919) || true) && (ndx >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(733, 3674, 3704) && ndx < f_733_3692_3704(_lines)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(733, 3670, 3919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3754, 3773);

                            return f_733_3761_3772(_lines, ndx);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(733, 3670, 3919);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(733, 3670, 3919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 3871, 3896);

                            return default(TextLine);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(733, 3670, 3919);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(733, 3587, 3938);

                        int
                        f_733_3692_3704(Microsoft.CodeAnalysis.Text.TextLineCollection
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(733, 3692, 3704);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextLine
                        f_733_3761_3772(Microsoft.CodeAnalysis.Text.TextLineCollection
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(733, 3761, 3772);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 3531, 3953);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 3531, 3953);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 3969, 4216);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4024, 4168) || true) && (_index < f_733_4037_4049(_lines) - 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(733, 4024, 4168);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4095, 4115);

                        _index = _index + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4137, 4149);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(733, 4024, 4168);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4188, 4201);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(733, 3969, 4216);

                    int
                    f_733_4037_4049(Microsoft.CodeAnalysis.Text.TextLineCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(733, 4037, 4049);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 3969, 4216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 3969, 4216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 4291, 4319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4297, 4317);

                        return this.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(733, 4291, 4319);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 4232, 4334);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 4232, 4334);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool IEnumerator.MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 4350, 4448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4410, 4433);

                    return this.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(733, 4350, 4448);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 4350, 4448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 4350, 4448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 4464, 4518);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(733, 4464, 4518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 4464, 4518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 4464, 4518);
                }
            }

            void IDisposable.Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 4534, 4590);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(733, 4534, 4590);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 4534, 4590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 4534, 4590);
                }
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 4606, 4728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4679, 4713);

                    throw f_733_4685_4712();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(733, 4606, 4728);

                    System.NotSupportedException
                    f_733_4685_4712()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 4685, 4712);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 4606, 4728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 4606, 4728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(733, 4744, 4859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(733, 4810, 4844);

                    throw f_733_4816_4843();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(733, 4744, 4859);

                    System.NotSupportedException
                    f_733_4816_4843()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(733, 4816, 4843);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(733, 4744, 4859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 4744, 4859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(733, 3075, 4870);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(733, 3075, 4870);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 3075, 4870);
            }
        }

        public TextLineCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(733, 517, 4877);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(733, 517, 4877);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 517, 4877);
        }


        static TextLineCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(733, 517, 4877);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(733, 517, 4877);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(733, 517, 4877);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(733, 517, 4877);
    }
}
