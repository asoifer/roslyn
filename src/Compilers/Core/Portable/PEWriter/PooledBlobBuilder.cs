// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Microsoft.Cci
{
    internal sealed class PooledBlobBuilder : BlobBuilder, IDisposable
    {
        private const int
        PoolSize = 128
        ;

        private const int
        ChunkSize = 1024
        ;

        private static readonly ObjectPool<PooledBlobBuilder> s_chunkPool;

        private PooledBlobBuilder(int size)
        : base(f_507_761_765_C(size))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(507, 705, 788);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(507, 705, 788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(507, 705, 788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 705, 788);
            }
        }

        public static PooledBlobBuilder GetInstance(int size = ChunkSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(507, 800, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 921, 951);

                return f_507_928_950(s_chunkPool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(507, 800, 962);

                Microsoft.Cci.PooledBlobBuilder
                f_507_928_950(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.Cci.PooledBlobBuilder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(507, 928, 950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(507, 800, 962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 800, 962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BlobBuilder AllocateChunk(int minimalSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(507, 974, 1230);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 1060, 1167) || true) && (minimalSize <= ChunkSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(507, 1060, 1167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 1122, 1152);

                    return f_507_1129_1151(s_chunkPool);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(507, 1060, 1167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 1183, 1219);

                return f_507_1190_1218(minimalSize);
                DynAbs.Tracing.TraceSender.TraceExitMethod(507, 974, 1230);

                Microsoft.Cci.PooledBlobBuilder
                f_507_1129_1151(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.Cci.PooledBlobBuilder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(507, 1129, 1151);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_507_1190_1218(int
                capacity)
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(507, 1190, 1218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(507, 974, 1230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 974, 1230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void FreeChunk()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(507, 1242, 1336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 1302, 1325);

                f_507_1302_1324(s_chunkPool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(507, 1242, 1336);

                int
                f_507_1302_1324(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.Cci.PooledBlobBuilder>
                this_param, Microsoft.Cci.PooledBlobBuilder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(507, 1302, 1324);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(507, 1242, 1336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 1242, 1336);
            }
        }

        public new void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(507, 1348, 1418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 1395, 1407);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 507, 1395, 1406);
                DynAbs.Tracing.TraceSender.TraceExitMethod(507, 1348, 1418);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(507, 1348, 1418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 1348, 1418);
            }
        }

        void IDisposable.Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(507, 1430, 1499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 1481, 1488);

                f_507_1481_1487(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(507, 1430, 1499);

                int
                f_507_1481_1487(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(507, 1481, 1487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(507, 1430, 1499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 1430, 1499);
            }
        }

        static PooledBlobBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(507, 368, 1506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 469, 483);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 512, 528);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(507, 595, 692);
            s_chunkPool = f_507_609_692(() => new PooledBlobBuilder(ChunkSize), PoolSize); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(507, 368, 1506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(507, 368, 1506);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(507, 368, 1506);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.Cci.PooledBlobBuilder>
        f_507_609_692(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.Cci.PooledBlobBuilder>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.Cci.PooledBlobBuilder>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(507, 609, 692);
            return return_v;
        }


        static int
        f_507_761_765_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(507, 705, 788);
            return return_v;
        }

    }
}
