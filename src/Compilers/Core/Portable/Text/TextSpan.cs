// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Serialization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{

    [DataContract]
    public readonly struct TextSpan : IEquatable<TextSpan>, IComparable<TextSpan>
    {

        public TextSpan(int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(734, 892, 1286);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 955, 1070) || true) && (start < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(734, 955, 1070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1002, 1055);

                    throw f_734_1008_1054(nameof(start));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(734, 955, 1070);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1086, 1215) || true) && (start + length < start)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(734, 1086, 1215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1146, 1200);

                    throw f_734_1152_1199(nameof(length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(734, 1086, 1215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1231, 1245);

                Start = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1259, 1275);

                Length = length;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(734, 892, 1286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 892, 1286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 892, 1286);
            }
        }

        [DataMember(Order = 0)]
        public int Start { get; }

        public int End
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 1545, 1562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1548, 1562);
                    return Start + Length; DynAbs.Tracing.TraceSender.TraceExitMethod(734, 1545, 1562);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 1545, 1562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 1545, 1562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [DataMember(Order = 1)]
        public int Length { get; }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 1851, 1870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 1854, 1870);
                    return this.Length == 0; DynAbs.Tracing.TraceSender.TraceExitMethod(734, 1851, 1870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 1851, 1870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 1851, 1870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 2280, 2408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 2339, 2397);

                return unchecked((uint)(position - Start) < (uint)Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 2280, 2408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 2280, 2408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 2280, 2408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Contains(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 2798, 2920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 2858, 2909);

                return span.Start >= Start && (DynAbs.Tracing.TraceSender.Expression_True(734, 2865, 2908) && span.End <= this.End);
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 2798, 2920);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 2798, 2920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 2798, 2920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool OverlapsWith(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 3427, 3658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 3491, 3538);

                int
                overlapStart = f_734_3510_3537(Start, span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 3552, 3598);

                int
                overlapEnd = f_734_3569_3597(this.End, span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 3614, 3647);

                return overlapStart < overlapEnd;
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 3427, 3658);

                int
                f_734_3510_3537(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 3510, 3537);
                    return return_v;
                }


                int
                f_734_3569_3597(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 3569, 3597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 3427, 3658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 3427, 3658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextSpan? Overlap(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 4009, 4340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 4073, 4120);

                int
                overlapStart = f_734_4092_4119(Start, span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 4134, 4180);

                int
                overlapEnd = f_734_4151_4179(this.End, span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 4196, 4329);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(734, 4203, 4228) || ((overlapStart < overlapEnd
                && DynAbs.Tracing.TraceSender.Conditional_F2(734, 4248, 4293)) || DynAbs.Tracing.TraceSender.Conditional_F3(734, 4313, 4328))) ? TextSpan.FromBounds(overlapStart, overlapEnd) : (TextSpan?)null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 4009, 4340);

                int
                f_734_4092_4119(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 4092, 4119);
                    return return_v;
                }


                int
                f_734_4151_4179(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 4151, 4179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 4009, 4340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 4009, 4340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IntersectsWith(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 4850, 4978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 4916, 4967);

                return span.Start <= this.End && (DynAbs.Tracing.TraceSender.Expression_True(734, 4923, 4966) && span.End >= Start);
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 4850, 4978);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 4850, 4978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 4850, 4978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IntersectsWith(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 5474, 5609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 5539, 5598);

                return unchecked((uint)(position - Start) <= (uint)Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 5474, 5609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 5474, 5609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 5474, 5609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextSpan? Intersection(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 5980, 6329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 6049, 6098);

                int
                intersectStart = f_734_6070_6097(Start, span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 6112, 6160);

                int
                intersectEnd = f_734_6131_6159(this.End, span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 6176, 6318);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(734, 6183, 6213) || ((intersectStart <= intersectEnd
                && DynAbs.Tracing.TraceSender.Conditional_F2(734, 6233, 6282)) || DynAbs.Tracing.TraceSender.Conditional_F3(734, 6302, 6317))) ? TextSpan.FromBounds(intersectStart, intersectEnd) : (TextSpan?)null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 5980, 6329);

                int
                f_734_6070_6097(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 6070, 6097);
                    return return_v;
                }


                int
                f_734_6131_6159(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 6131, 6159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 5980, 6329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 5980, 6329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TextSpan FromBounds(int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(734, 6717, 7203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 6795, 6956) || true) && (start < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(734, 6795, 6956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 6842, 6941);

                    throw f_734_6848_6940(nameof(start), f_734_6895_6939());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(734, 6795, 6956);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 6972, 7136) || true) && (end < start)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(734, 6972, 7136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 7021, 7121);

                    throw f_734_7027_7120(nameof(end), f_734_7072_7119());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(734, 6972, 7136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 7152, 7192);

                return f_734_7159_7191(start, end - start);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(734, 6717, 7203);

                string
                f_734_6895_6939()
                {
                    var return_v = CodeAnalysisResources.StartMustNotBeNegative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(734, 6895, 6939);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_734_6848_6940(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 6848, 6940);
                    return return_v;
                }


                string
                f_734_7072_7119()
                {
                    var return_v = CodeAnalysisResources.EndMustNotBeLessThanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(734, 7072, 7119);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_734_7027_7120(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 7027, 7120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_734_7159_7191(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 7159, 7191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 6717, 7203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 6717, 7203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(TextSpan left, TextSpan right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(734, 7343, 7466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 7429, 7455);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(734, 7343, 7466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 7343, 7466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 7343, 7466);
            }
        }

        public static bool operator !=(TextSpan left, TextSpan right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(734, 7607, 7731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 7693, 7720);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(734, 7607, 7731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 7607, 7731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 7607, 7731);
            }
        }

        public bool Equals(TextSpan other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 7881, 8005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 7940, 7994);

                return Start == other.Start && (DynAbs.Tracing.TraceSender.Expression_True(734, 7947, 7993) && Length == other.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 7881, 8005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 7881, 8005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 7881, 8005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 8155, 8279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 8220, 8268);

                return obj is TextSpan && (DynAbs.Tracing.TraceSender.Expression_True(734, 8227, 8267) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 8155, 8279);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 8155, 8279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 8155, 8279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 8400, 8504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 8458, 8493);

                return f_734_8465_8492(Start, Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 8400, 8504);

                int
                f_734_8465_8492(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 8465, 8492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 8400, 8504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 8400, 8504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 8637, 8733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 8695, 8722);

                return $"[{Start}..{End})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 8637, 8733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 8637, 8733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 8637, 8733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(TextSpan other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(734, 8871, 9107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 8932, 8963);

                var
                diff = Start - other.Start
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 8977, 9051) || true) && (diff != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(734, 8977, 9051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 9024, 9036);

                    return diff;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(734, 8977, 9051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(734, 9067, 9096);

                return Length - other.Length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(734, 8871, 9107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(734, 8871, 9107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 8871, 9107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TextSpan()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(734, 578, 9114);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(734, 578, 9114);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(734, 578, 9114);
        }

        static System.ArgumentOutOfRangeException
        f_734_1008_1054(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 1008, 1054);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_734_1152_1199(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(734, 1152, 1199);
            return return_v;
        }

    }
}
