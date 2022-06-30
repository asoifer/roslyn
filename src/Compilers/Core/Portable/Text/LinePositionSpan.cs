// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Serialization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{

    [DataContract]
    public readonly struct LinePositionSpan : IEquatable<LinePositionSpan>
    {

        [DataMember(Order = 0)]
        private readonly LinePosition _start;

        [DataMember(Order = 1)]
        private readonly LinePosition _end;

        public LinePositionSpan(LinePosition start, LinePosition end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(718, 1058, 1365);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1144, 1298) || true) && (end < start)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(718, 1144, 1298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1193, 1283);

                    throw f_718_1199_1282(f_718_1221_1268(), nameof(end));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(718, 1144, 1298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1314, 1329);

                _start = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1343, 1354);

                _end = end;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(718, 1058, 1365);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 1058, 1365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 1058, 1365);
            }
        }

        public LinePosition Start
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(718, 1524, 1546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1530, 1544);

                    return _start;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(718, 1524, 1546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 1474, 1557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 1474, 1557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LinePosition End
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(718, 1712, 1732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1718, 1730);

                    return _end;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(718, 1712, 1732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 1664, 1743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 1664, 1743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(718, 1755, 1895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1820, 1884);

                return obj is LinePositionSpan && (DynAbs.Tracing.TraceSender.Expression_True(718, 1827, 1883) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(718, 1755, 1895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 1755, 1895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 1755, 1895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(LinePositionSpan other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(718, 1907, 2064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 1974, 2053);

                return _start.Equals(other._start) && (DynAbs.Tracing.TraceSender.Expression_True(718, 1981, 2052) && _end.Equals(other._end));
                DynAbs.Tracing.TraceSender.TraceExitMethod(718, 1907, 2064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 1907, 2064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 1907, 2064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(718, 2076, 2207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 2134, 2196);

                return f_718_2141_2195(_start.GetHashCode(), _end.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(718, 2076, 2207);

                int
                f_718_2141_2195(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(718, 2141, 2195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 2076, 2207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 2076, 2207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(LinePositionSpan left, LinePositionSpan right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(718, 2219, 2358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 2321, 2347);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(718, 2219, 2358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 2219, 2358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 2219, 2358);
            }
        }

        public static bool operator !=(LinePositionSpan left, LinePositionSpan right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(718, 2370, 2510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 2472, 2499);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(718, 2370, 2510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 2370, 2510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 2370, 2510);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(718, 2695, 2814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(718, 2753, 2803);

                return f_718_2760_2802("({0})-({1})", _start, _end);
                DynAbs.Tracing.TraceSender.TraceExitMethod(718, 2695, 2814);

                string
                f_718_2760_2802(string
                format, Microsoft.CodeAnalysis.Text.LinePosition
                arg0, Microsoft.CodeAnalysis.Text.LinePosition
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(718, 2760, 2802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(718, 2695, 2814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 2695, 2814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LinePositionSpan()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(718, 460, 2821);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(718, 460, 2821);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(718, 460, 2821);
        }

        static string
        f_718_1221_1268()
        {
            var return_v = CodeAnalysisResources.EndMustNotBeLessThanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(718, 1221, 1268);
            return return_v;
        }


        static System.ArgumentException
        f_718_1199_1282(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(718, 1199, 1282);
            return return_v;
        }

    }
}
