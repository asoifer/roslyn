// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal sealed class BlobBuildingStream : Stream
    {
        private static readonly ObjectPool<BlobBuildingStream> s_pool;

        private readonly BlobBuilder _builder;

        public const int
        ChunkSize = 32 * 1024
        ;

        public override bool CanWrite
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 1924, 1931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 1927, 1931);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(310, 1924, 1931);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 1924, 1931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 1924, 1931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanRead
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 1971, 1979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 1974, 1979);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(310, 1971, 1979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 1971, 1979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 1971, 1979);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 2019, 2027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2022, 2027);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(310, 2019, 2027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2019, 2027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2019, 2027);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 2066, 2083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2069, 2083);
                    return f_310_2069_2083(_builder); DynAbs.Tracing.TraceSender.TraceExitMethod(310, 2066, 2083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2066, 2083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2066, 2083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static BlobBuildingStream GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(310, 2096, 2203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2167, 2192);

                return f_310_2174_2191(s_pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(310, 2096, 2203);

                Roslyn.Utilities.BlobBuildingStream
                f_310_2174_2191(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.BlobBuildingStream>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 2174, 2191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2096, 2203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2096, 2203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlobBuildingStream()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(310, 2215, 2523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 803, 811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2474, 2512);

                _builder = f_310_2485_2511(ChunkSize);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(310, 2215, 2523);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2215, 2523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2215, 2523);
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 2535, 2678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2624, 2667);

                f_310_2624_2666(_builder, buffer, offset, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 2535, 2678);

                int
                f_310_2624_2666(System.Reflection.Metadata.BlobBuilder
                this_param, byte[]
                buffer, int
                start, int
                byteCount)
                {
                    this_param.WriteBytes(buffer, start, byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 2624, 2666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2535, 2678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2535, 2678);
            }
        }

        public override void WriteByte(byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 2690, 2794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2757, 2783);

                f_310_2757_2782(_builder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 2690, 2794);

                int
                f_310_2757_2782(System.Reflection.Metadata.BlobBuilder
                this_param, byte
                value)
                {
                    this_param.WriteByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 2757, 2782);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2690, 2794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2690, 2794);
            }
        }

        public void WriteInt32(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 2806, 2902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2864, 2891);

                f_310_2864_2890(_builder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 2806, 2902);

                int
                f_310_2864_2890(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 2864, 2890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2806, 2902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2806, 2902);
            }
        }

        public Blob ReserveBytes(int byteCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 2914, 3029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 2978, 3018);

                return f_310_2985_3017(_builder, byteCount);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 2914, 3029);

                System.Reflection.Metadata.Blob
                f_310_2985_3017(System.Reflection.Metadata.BlobBuilder
                this_param, int
                byteCount)
                {
                    var return_v = this_param.ReserveBytes(byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 2985, 3017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 2914, 3029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 2914, 3029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<byte> ToImmutableArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3041, 3158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3112, 3147);

                return f_310_3119_3146(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3041, 3158);

                System.Collections.Immutable.ImmutableArray<byte>
                f_310_3119_3146(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3119, 3146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3041, 3158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3041, 3158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3170, 3333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3213, 3230);

                f_310_3213_3229(_builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3274, 3292);

                f_310_3274_3291(s_pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3170, 3333);

                int
                f_310_3213_3229(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3213, 3229);
                    return 0;
                }


                int
                f_310_3274_3291(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.BlobBuildingStream>
                this_param, Roslyn.Utilities.BlobBuildingStream
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3274, 3291);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3170, 3333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3170, 3333);
            }
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3345, 3395);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3345, 3395);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3345, 3395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3345, 3395);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3407, 3535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3479, 3503);

                f_310_3479_3502(disposing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3517, 3524);

                f_310_3517_3523(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3407, 3535);

                int
                f_310_3479_3502(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3479, 3502);
                    return 0;
                }


                int
                f_310_3517_3523(Roslyn.Utilities.BlobBuildingStream
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3517, 3523);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3407, 3535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3407, 3535);
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3547, 3674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3629, 3663);

                throw f_310_3635_3662();
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3547, 3674);

                System.NotSupportedException
                f_310_3635_3662()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3635, 3662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3547, 3674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3547, 3674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3686, 3818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3773, 3807);

                throw f_310_3779_3806();
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3686, 3818);

                System.NotSupportedException
                f_310_3779_3806()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3779, 3806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3686, 3818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3686, 3818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetLength(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 3830, 3942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 3897, 3931);

                throw f_310_3903_3930();
                DynAbs.Tracing.TraceSender.TraceExitMethod(310, 3830, 3942);

                System.NotSupportedException
                f_310_3903_3930()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 3903, 3930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3830, 3942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3830, 3942);
            }
        }

        public override long Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 4008, 4050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 4014, 4048);

                    throw f_310_4020_4047();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(310, 4008, 4050);

                    System.NotSupportedException
                    f_310_4020_4047()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 4020, 4047);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3954, 4117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3954, 4117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(310, 4064, 4106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 4070, 4104);

                    throw f_310_4076_4103();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(310, 4064, 4106);

                    System.NotSupportedException
                    f_310_4076_4103()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 4076, 4103);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(310, 3954, 4117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 3954, 4117);
                }
            }
        }

        static BlobBuildingStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(310, 567, 4126);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 688, 763);
            s_pool = f_310_697_763(() => new BlobBuildingStream()); DynAbs.Tracing.TraceSender.TraceSimpleStatement(310, 1860, 1881);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(310, 567, 4126);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(310, 567, 4126);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(310, 567, 4126);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.BlobBuildingStream>
        f_310_697_763(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.BlobBuildingStream>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.BlobBuildingStream>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 697, 763);
            return return_v;
        }


        int
        f_310_2069_2083(System.Reflection.Metadata.BlobBuilder
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(310, 2069, 2083);
            return return_v;
        }


        static System.Reflection.Metadata.BlobBuilder
        f_310_2485_2511(int
        capacity)
        {
            var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(310, 2485, 2511);
            return return_v;
        }

    }
}
