// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis
{
    internal sealed class ReadOnlyUnmanagedMemoryStream : Stream
    {
        private readonly object _memoryOwner;

        private readonly IntPtr _data;

        private readonly int _length;

        private int _position;

        public ReadOnlyUnmanagedMemoryStream(object memoryOwner, IntPtr data, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(358, 560, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 424, 436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 508, 515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 538, 547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 666, 693);

                _memoryOwner = memoryOwner;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 707, 720);

                _data = data;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 734, 751);

                _length = length;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(358, 560, 762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 560, 762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 560, 762);
            }
        }

        public override unsafe int ReadByte()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 774, 981);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 836, 919) || true) && (_position == _length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(358, 836, 919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 894, 904);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(358, 836, 919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 935, 970);

                return ((byte*)_data)[_position++];
                DynAbs.Tracing.TraceSender.TraceExitMethod(358, 774, 981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 774, 981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 774, 981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 993, 1285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1080, 1133);

                int
                bytesRead = f_358_1096_1132(count, _length - _position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1147, 1206);

                f_358_1147_1205(_data + _position, buffer, offset, bytesRead);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1220, 1243);

                _position += bytesRead;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1257, 1274);

                return bytesRead;
                DynAbs.Tracing.TraceSender.TraceExitMethod(358, 993, 1285);

                int
                f_358_1096_1132(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 1096, 1132);
                    return return_v;
                }


                int
                f_358_1147_1205(System.IntPtr
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy(source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 1147, 1205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 993, 1285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 993, 1285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 1297, 1347);
                DynAbs.Tracing.TraceSender.TraceExitMethod(358, 1297, 1347);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1297, 1347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1297, 1347);
            }
        }

        public override bool CanRead
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 1412, 1475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1448, 1460);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(358, 1412, 1475);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1359, 1486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1359, 1486);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 1551, 1614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1587, 1599);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(358, 1551, 1614);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1498, 1625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1498, 1625);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 1691, 1755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1727, 1740);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(358, 1691, 1755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1637, 1766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1637, 1766);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 1830, 1896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 1866, 1881);

                    return _length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(358, 1830, 1896);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1778, 1907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1778, 1907);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 1973, 2041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2009, 2026);

                    return _position;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(358, 1973, 2041);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1919, 2149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1919, 2149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 2057, 2138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2093, 2123);

                    f_358_2093_2122(this, value, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(358, 2057, 2138);

                    long
                    f_358_2093_2122(Microsoft.CodeAnalysis.ReadOnlyUnmanagedMemoryStream
                    this_param, long
                    offset, System.IO.SeekOrigin
                    origin)
                    {
                        var return_v = this_param.Seek(offset, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 2093, 2122);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 1919, 2149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 1919, 2149);
                }
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 2161, 3257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2243, 2255);

                long
                target
                = default(long);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2305, 2868);

                    switch (origin)
                    {

                        case SeekOrigin.Begin:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(358, 2305, 2868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2409, 2425);

                            target = offset;
                            DynAbs.Tracing.TraceSender.TraceBreak(358, 2451, 2457);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(358, 2305, 2868);

                        case SeekOrigin.Current:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(358, 2305, 2868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2531, 2568);

                            target = checked(offset + _position);
                            DynAbs.Tracing.TraceSender.TraceBreak(358, 2594, 2600);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(358, 2305, 2868);

                        case SeekOrigin.End:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(358, 2305, 2868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2670, 2705);

                            target = checked(offset + _length);
                            DynAbs.Tracing.TraceSender.TraceBreak(358, 2731, 2737);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(358, 2305, 2868);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(358, 2305, 2868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2795, 2849);

                            throw f_358_2801_2848(nameof(origin));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(358, 2305, 2868);
                    }
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(358, 2897, 3024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 2955, 3009);

                    throw f_358_2961_3008(nameof(offset));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(358, 2897, 3024);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 3040, 3178) || true) && (target < 0 || (DynAbs.Tracing.TraceSender.Expression_False(358, 3044, 3075) || target >= _length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(358, 3040, 3178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 3109, 3163);

                    throw f_358_3115_3162(nameof(offset));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(358, 3040, 3178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 3194, 3218);

                _position = (int)target;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 3232, 3246);

                return target;
                DynAbs.Tracing.TraceSender.TraceExitMethod(358, 2161, 3257);

                System.ArgumentOutOfRangeException
                f_358_2801_2848(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 2801, 2848);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_358_2961_3008(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 2961, 3008);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_358_3115_3162(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 3115, 3162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 2161, 3257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 2161, 3257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetLength(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 3269, 3381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 3336, 3370);

                throw f_358_3342_3369();
                DynAbs.Tracing.TraceSender.TraceExitMethod(358, 3269, 3381);

                System.NotSupportedException
                f_358_3342_3369()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 3342, 3369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 3269, 3381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 3269, 3381);
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(358, 3393, 3527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(358, 3482, 3516);

                throw f_358_3488_3515();
                DynAbs.Tracing.TraceSender.TraceExitMethod(358, 3393, 3527);

                System.NotSupportedException
                f_358_3488_3515()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(358, 3488, 3515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(358, 3393, 3527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 3393, 3527);
            }
        }

        static ReadOnlyUnmanagedMemoryStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(358, 323, 3534);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(358, 323, 3534);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(358, 323, 3534);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(358, 323, 3534);
    }
}
