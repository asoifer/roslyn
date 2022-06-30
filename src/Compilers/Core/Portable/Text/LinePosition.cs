// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Serialization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{

    [DataContract]
    public readonly struct LinePosition : IEquatable<LinePosition>, IComparable<LinePosition>
    {

        public static LinePosition Zero
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 751, 775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 754, 775);
                    return default(LinePosition); DynAbs.Tracing.TraceSender.TraceExitMethod(717, 751, 775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 751, 775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 751, 775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [DataMember(Order = 0)]
        private readonly int _line;

        [DataMember(Order = 1)]
        private readonly int _character;

        public LinePosition(int line, int character)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(717, 1521, 1919);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 1590, 1703) || true) && (line < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(717, 1590, 1703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 1636, 1688);

                    throw f_717_1642_1687(nameof(line));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(717, 1590, 1703);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 1719, 1842) || true) && (character < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(717, 1719, 1842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 1770, 1827);

                    throw f_717_1776_1826(nameof(character));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(717, 1719, 1842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 1858, 1871);

                _line = line;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 1885, 1908);

                _character = character;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(717, 1521, 1919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 1521, 1919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 1521, 1919);
            }
        }

        internal LinePosition(int character)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(717, 2237, 2496);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 2298, 2421) || true) && (character < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(717, 2298, 2421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 2349, 2406);

                    throw f_717_2355_2405(nameof(character));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(717, 2298, 2421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 2437, 2448);

                _line = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 2462, 2485);

                _character = character;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(717, 2237, 2496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 2237, 2496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 2237, 2496);
            }
        }

        public int Line
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 2700, 2721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 2706, 2719);

                    return _line;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(717, 2700, 2721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 2660, 2732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 2660, 2732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Character
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 2889, 2915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 2895, 2913);

                    return _character;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(717, 2889, 2915);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 2844, 2926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 2844, 2926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool operator ==(LinePosition left, LinePosition right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(717, 3062, 3193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 3156, 3182);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(717, 3062, 3193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 3062, 3193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 3062, 3193);
            }
        }

        public static bool operator !=(LinePosition left, LinePosition right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(717, 3330, 3462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 3424, 3451);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(717, 3330, 3462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 3330, 3462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 3330, 3462);
            }
        }

        public bool Equals(LinePosition other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 3662, 3804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 3725, 3793);

                return other.Line == this.Line && (DynAbs.Tracing.TraceSender.Expression_True(717, 3732, 3792) && other.Character == this.Character);
                DynAbs.Tracing.TraceSender.TraceExitMethod(717, 3662, 3804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 3662, 3804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 3662, 3804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 4002, 4134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 4067, 4123);

                return obj is LinePosition && (DynAbs.Tracing.TraceSender.Expression_True(717, 4074, 4122) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(717, 4002, 4134);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 4002, 4134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 4002, 4134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 4263, 4369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 4321, 4358);

                return f_717_4328_4357(Line, Character);
                DynAbs.Tracing.TraceSender.TraceExitMethod(717, 4263, 4369);

                int
                f_717_4328_4357(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 4328, 4357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 4263, 4369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 4263, 4369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 4543, 4642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 4601, 4631);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Line).ToString(), 717, 4608, 4612) + "," + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Character).ToString(), 717, 4621, 4630);
                var temp = (Line).ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 4608, 4612);
                temp += "," + (Character).ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 4621, 4630);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(717, 4543, 4642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 4543, 4642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 4543, 4642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(LinePosition other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(717, 4654, 4856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 4719, 4761);

                int
                result = f_717_4732_4760(_line, other._line)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 4775, 4845);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(717, 4782, 4795) || (((result != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(717, 4798, 4804)) || DynAbs.Tracing.TraceSender.Conditional_F3(717, 4807, 4844))) ? result : f_717_4807_4844(_character, other.Character);
                DynAbs.Tracing.TraceSender.TraceExitMethod(717, 4654, 4856);

                int
                f_717_4732_4760(int
                this_param, int
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 4732, 4760);
                    return return_v;
                }


                int
                f_717_4807_4844(int
                this_param, int
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 4807, 4844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 4654, 4856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 4654, 4856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator >(LinePosition left, LinePosition right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(717, 4868, 5005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 4961, 4994);

                return left.CompareTo(right) > 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(717, 4868, 5005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 4868, 5005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 4868, 5005);
            }
        }

        public static bool operator >=(LinePosition left, LinePosition right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(717, 5017, 5156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 5111, 5145);

                return left.CompareTo(right) >= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(717, 5017, 5156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 5017, 5156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 5017, 5156);
            }
        }

        public static bool operator <(LinePosition left, LinePosition right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(717, 5168, 5305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 5261, 5294);

                return left.CompareTo(right) < 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(717, 5168, 5305);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 5168, 5305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 5168, 5305);
            }
        }

        public static bool operator <=(LinePosition left, LinePosition right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(717, 5317, 5456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(717, 5411, 5445);

                return left.CompareTo(right) <= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(717, 5317, 5456);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(717, 5317, 5456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 5317, 5456);
            }
        }
        static LinePosition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(717, 466, 5463);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(717, 466, 5463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(717, 466, 5463);
        }

        static System.ArgumentOutOfRangeException
        f_717_1642_1687(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 1642, 1687);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_717_1776_1826(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 1776, 1826);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_717_2355_2405(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(717, 2355, 2405);
            return return_v;
        }

    }
}
