// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;

namespace Microsoft.CodeAnalysis.Collections
{
    internal sealed class ImmutableMemoryStream : Stream
    {
        private readonly ImmutableArray<byte> _array;

        private int _position;

        internal ImmutableMemoryStream(ImmutableArray<byte> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(106, 518, 672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 496, 505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 601, 632);

                f_106_601_631(f_106_614_630_M(!array.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 646, 661);

                _array = array;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(106, 518, 672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 518, 672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 518, 672);
            }
        }

        public ImmutableArray<byte> GetBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 684, 773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 748, 762);

                return _array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(106, 684, 773);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 684, 773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 684, 773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool CanRead
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 838, 858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 844, 856);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(106, 838, 858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 785, 869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 785, 869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanSeek
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 934, 954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 940, 952);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(106, 934, 954);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 881, 965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 881, 965);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanWrite
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1031, 1052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1037, 1050);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1031, 1052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 977, 1063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 977, 1063);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override long Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1127, 1156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1133, 1154);

                    return _array.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1127, 1156);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 1075, 1167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 1075, 1167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override long Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1233, 1301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1269, 1286);

                    return _position;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1233, 1301);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 1179, 1573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 1179, 1573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1315, 1562);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1351, 1504) || true) && (value < 0 || (DynAbs.Tracing.TraceSender.Expression_False(106, 1355, 1390) || value >= _array.Length))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(106, 1351, 1504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1432, 1485);

                        throw f_106_1438_1484(nameof(value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(106, 1351, 1504);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1524, 1547);

                    _position = (int)value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1315, 1562);

                    System.ArgumentOutOfRangeException
                    f_106_1438_1484(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 1438, 1484);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 1179, 1573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 1179, 1573);
                }
            }
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1585, 1635);
                DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1585, 1635);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 1585, 1635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 1585, 1635);
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1647, 1926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1734, 1790);

                int
                result = f_106_1747_1789(count, _array.Length - _position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1804, 1853);

                _array.CopyTo(_position, buffer, offset, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1867, 1887);

                _position += result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 1901, 1915);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1647, 1926);

                int
                f_106_1747_1789(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 1747, 1789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 1647, 1926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 1647, 1926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 1938, 3046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2020, 2032);

                long
                target
                = default(long);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2082, 2651);

                    switch (origin)
                    {

                        case SeekOrigin.Begin:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(106, 2082, 2651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2186, 2202);

                            target = offset;
                            DynAbs.Tracing.TraceSender.TraceBreak(106, 2228, 2234);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(106, 2082, 2651);

                        case SeekOrigin.Current:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(106, 2082, 2651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2308, 2345);

                            target = checked(offset + _position);
                            DynAbs.Tracing.TraceSender.TraceBreak(106, 2371, 2377);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(106, 2082, 2651);

                        case SeekOrigin.End:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(106, 2082, 2651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2447, 2488);

                            target = checked(offset + _array.Length);
                            DynAbs.Tracing.TraceSender.TraceBreak(106, 2514, 2520);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(106, 2082, 2651);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(106, 2082, 2651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2578, 2632);

                            throw f_106_2584_2631(nameof(origin));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(106, 2082, 2651);
                    }
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(106, 2680, 2807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2738, 2792);

                    throw f_106_2744_2791(nameof(offset));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(106, 2680, 2807);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2823, 2967) || true) && (target < 0 || (DynAbs.Tracing.TraceSender.Expression_False(106, 2827, 2864) || target >= _array.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(106, 2823, 2967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2898, 2952);

                    throw f_106_2904_2951(nameof(offset));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(106, 2823, 2967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 2983, 3007);

                _position = (int)target;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 3021, 3035);

                return target;
                DynAbs.Tracing.TraceSender.TraceExitMethod(106, 1938, 3046);

                System.ArgumentOutOfRangeException
                f_106_2584_2631(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 2584, 2631);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_106_2744_2791(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 2744, 2791);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_106_2904_2951(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 2904, 2951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 1938, 3046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 1938, 3046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetLength(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 3058, 3170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 3125, 3159);

                throw f_106_3131_3158();
                DynAbs.Tracing.TraceSender.TraceExitMethod(106, 3058, 3170);

                System.NotSupportedException
                f_106_3131_3158()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 3131, 3158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 3058, 3170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 3058, 3170);
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(106, 3182, 3316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(106, 3271, 3305);

                throw f_106_3277_3304();
                DynAbs.Tracing.TraceSender.TraceExitMethod(106, 3182, 3316);

                System.NotSupportedException
                f_106_3277_3304()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 3277, 3304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(106, 3182, 3316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 3182, 3316);
            }
        }

        static ImmutableMemoryStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(106, 360, 3323);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(106, 360, 3323);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(106, 360, 3323);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(106, 360, 3323);

        bool
        f_106_614_630_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(106, 614, 630);
            return return_v;
        }


        static int
        f_106_601_631(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(106, 601, 631);
            return 0;
        }

    }
}
