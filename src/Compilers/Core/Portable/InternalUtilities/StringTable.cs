// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal class StringTable
    {
        private struct Entry
        {

            public int HashCode;

            public string Text;
            static Entry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(387, 696, 884);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(387, 696, 884);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 696, 884);
            }
        }

        private const int
        LocalSizeBits = 11
        ;

        private const int
        LocalSize = (1 << LocalSizeBits)
        ;

        private const int
        LocalSizeMask = LocalSize - 1
        ;

        private const int
        SharedSizeBits = 16
        ;

        private const int
        SharedSize = (1 << SharedSizeBits)
        ;

        private const int
        SharedSizeMask = SharedSize - 1
        ;

        private const int
        SharedBucketBits = 4
        ;

        private const int
        SharedBucketSize = (1 << SharedBucketBits)
        ;

        private const int
        SharedBucketSizeMask = SharedBucketSize - 1
        ;

        private readonly Entry[] _localTable;

        private static readonly Entry[] s_sharedTable;

        private int _localRandom;

        private static int s_sharedRandom;

        internal StringTable() : this(f_387_3015_3019_C(null))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(387, 2972, 3042);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(387, 2972, 3042);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 2972, 3042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 2972, 3042);
            }
        }

        private StringTable(ObjectPool<StringTable>? pool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(387, 3130, 3229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 2203, 2237);
                this._localTable = new Entry[LocalSize]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 2766, 2802);
                this._localRandom = f_387_2781_2802(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3283, 3288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3205, 3218);

                _pool = pool;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(387, 3130, 3229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 3130, 3229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 3130, 3229);
            }
        }

        private readonly ObjectPool<StringTable>? _pool;

        private static readonly ObjectPool<StringTable> s_staticPool;

        private static ObjectPool<StringTable> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 3387, 3602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3463, 3565);

                var
                pool = f_387_3474_3564(pool => new StringTable(pool), f_387_3533_3559() * 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3579, 3591);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 3387, 3602);

                int
                f_387_3533_3559()
                {
                    var return_v = Environment.ProcessorCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 3533, 3559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>
                f_387_3474_3564(System.Func<Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>, Roslyn.Utilities.StringTable>
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 3474, 3564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 3387, 3602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 3387, 3602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StringTable GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 3614, 3720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3678, 3709);

                return f_387_3685_3708(s_staticPool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 3614, 3720);

                Roslyn.Utilities.StringTable
                f_387_3685_3708(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 3685, 3708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 3614, 3720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 3614, 3720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 3732, 4021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3992, 4010);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_pool, 387, 3992, 4009)?.Free(this), 387, 3998, 4009);
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 3732, 4021);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 3732, 4021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 3732, 4021);
            }
        }

        internal string Add(char[] chars, int start, int len)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 4067, 5262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4145, 4181);

                var
                span = f_387_4156_4180(chars, start, len)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4195, 4249);

                var
                hashCode = f_387_4210_4248(chars, start, len)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4323, 4345);

                var
                arr = _localTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4359, 4396);

                var
                idx = f_387_4369_4395(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4412, 4437);

                var
                text = arr[idx].Text
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4453, 4711) || true) && (text != null && (DynAbs.Tracing.TraceSender.Expression_True(387, 4457, 4502) && arr[idx].HashCode == hashCode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 4453, 4711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4536, 4563);

                    var
                    result = arr[idx].Text
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4581, 4696) || true) && (f_387_4585_4621(result, span))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 4581, 4696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4663, 4677);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(387, 4581, 4696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 4453, 4711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4727, 4789);

                string?
                shared = f_387_4744_4788(chars, start, len, hashCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 4803, 5191) || true) && (shared != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 4803, 5191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5072, 5101);

                    arr[idx].HashCode = hashCode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5119, 5142);

                    arr[idx].Text = shared;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5162, 5176);

                    return shared;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 4803, 5191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5207, 5251);

                return f_387_5214_5250(this, chars, start, len, hashCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 4067, 5262);

                System.Span<char>
                f_387_4156_4180(char[]
                array, int
                start, int
                length)
                {
                    var return_v = array.AsSpan<char>(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 4156, 4180);
                    return return_v;
                }


                int
                f_387_4210_4248(char[]
                text, int
                start, int
                length)
                {
                    var return_v = Hash.GetFNVHashCode(text, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 4210, 4248);
                    return return_v;
                }


                int
                f_387_4369_4395(int
                hash)
                {
                    var return_v = LocalIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 4369, 4395);
                    return return_v;
                }


                bool
                f_387_4585_4621(string
                array, System.Span<char>
                text)
                {
                    var return_v = StringTable.TextEquals(array, (System.ReadOnlySpan<char>)text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 4585, 4621);
                    return return_v;
                }


                string?
                f_387_4744_4788(char[]
                chars, int
                start, int
                len, int
                hashCode)
                {
                    var return_v = FindSharedEntry(chars, start, len, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 4744, 4788);
                    return return_v;
                }


                string
                f_387_5214_5250(Roslyn.Utilities.StringTable
                this_param, char[]
                chars, int
                start, int
                len, int
                hashCode)
                {
                    var return_v = this_param.AddItem(chars, start, len, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 5214, 5250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 4067, 5262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 4067, 5262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Add(string chars, int start, int len)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 5274, 6432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5352, 5406);

                var
                hashCode = f_387_5367_5405(chars, start, len)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5480, 5502);

                var
                arr = _localTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5516, 5553);

                var
                idx = f_387_5526_5552(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5569, 5594);

                var
                text = arr[idx].Text
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5610, 5881) || true) && (text != null && (DynAbs.Tracing.TraceSender.Expression_True(387, 5614, 5659) && arr[idx].HashCode == hashCode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 5610, 5881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5693, 5720);

                    var
                    result = arr[idx].Text
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5738, 5866) || true) && (f_387_5742_5791(result, chars, start, len))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 5738, 5866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5833, 5847);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(387, 5738, 5866);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 5610, 5881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5897, 5959);

                string?
                shared = f_387_5914_5958(chars, start, len, hashCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 5973, 6361) || true) && (shared != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 5973, 6361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6242, 6271);

                    arr[idx].HashCode = hashCode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6289, 6312);

                    arr[idx].Text = shared;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6332, 6346);

                    return shared;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 5973, 6361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6377, 6421);

                return f_387_6384_6420(this, chars, start, len, hashCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 5274, 6432);

                int
                f_387_5367_5405(string
                text, int
                start, int
                length)
                {
                    var return_v = Hash.GetFNVHashCode(text, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 5367, 5405);
                    return return_v;
                }


                int
                f_387_5526_5552(int
                hash)
                {
                    var return_v = LocalIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 5526, 5552);
                    return return_v;
                }


                bool
                f_387_5742_5791(string
                array, string
                text, int
                start, int
                length)
                {
                    var return_v = StringTable.TextEquals(array, text, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 5742, 5791);
                    return return_v;
                }


                string?
                f_387_5914_5958(string
                chars, int
                start, int
                len, int
                hashCode)
                {
                    var return_v = FindSharedEntry(chars, start, len, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 5914, 5958);
                    return return_v;
                }


                string
                f_387_6384_6420(Roslyn.Utilities.StringTable
                this_param, string
                chars, int
                start, int
                len, int
                hashCode)
                {
                    var return_v = this_param.AddItem(chars, start, len, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 6384, 6420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 5274, 6432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 5274, 6432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Add(char chars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 6444, 7498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6500, 6542);

                var
                hashCode = f_387_6515_6541(chars)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6616, 6638);

                var
                arr = _localTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6652, 6689);

                var
                idx = f_387_6662_6688(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6705, 6730);

                var
                text = arr[idx].Text
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6746, 6971) || true) && (text != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 6746, 6971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6796, 6823);

                    var
                    result = arr[idx].Text
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6841, 6956) || true) && (f_387_6845_6856(text) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(387, 6845, 6881) && f_387_6865_6872(text, 0) == chars))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 6841, 6956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6923, 6937);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(387, 6841, 6956);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 6746, 6971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 6987, 7037);

                string?
                shared = f_387_7004_7036(chars, hashCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7051, 7439) || true) && (shared != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 7051, 7439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7320, 7349);

                    arr[idx].HashCode = hashCode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7367, 7390);

                    arr[idx].Text = shared;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7410, 7424);

                    return shared;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 7051, 7439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7455, 7487);

                return f_387_7462_7486(this, chars, hashCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 6444, 7498);

                int
                f_387_6515_6541(char
                ch)
                {
                    var return_v = Hash.GetFNVHashCode(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 6515, 6541);
                    return return_v;
                }


                int
                f_387_6662_6688(int
                hash)
                {
                    var return_v = LocalIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 6662, 6688);
                    return return_v;
                }


                int
                f_387_6845_6856(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 6845, 6856);
                    return return_v;
                }


                char
                f_387_6865_6872(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 6865, 6872);
                    return return_v;
                }


                string?
                f_387_7004_7036(char
                chars, int
                hashCode)
                {
                    var return_v = FindSharedEntry(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 7004, 7036);
                    return return_v;
                }


                string
                f_387_7462_7486(Roslyn.Utilities.StringTable
                this_param, char
                chars, int
                hashCode)
                {
                    var return_v = this_param.AddItem(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 7462, 7486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 6444, 7498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 6444, 7498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Add(StringBuilder chars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 7510, 8607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7575, 7617);

                var
                hashCode = f_387_7590_7616(chars)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7691, 7713);

                var
                arr = _localTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7727, 7764);

                var
                idx = f_387_7737_7763(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7780, 7805);

                var
                text = arr[idx].Text
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7821, 8080) || true) && (text != null && (DynAbs.Tracing.TraceSender.Expression_True(387, 7825, 7870) && arr[idx].HashCode == hashCode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 7821, 8080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7904, 7931);

                    var
                    result = arr[idx].Text
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 7949, 8065) || true) && (f_387_7953_7990(result, chars))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 7949, 8065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8032, 8046);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(387, 7949, 8065);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 7821, 8080);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8096, 8146);

                string?
                shared = f_387_8113_8145(chars, hashCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8160, 8548) || true) && (shared != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 8160, 8548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8429, 8458);

                    arr[idx].HashCode = hashCode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8476, 8499);

                    arr[idx].Text = shared;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8519, 8533);

                    return shared;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 8160, 8548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8564, 8596);

                return f_387_8571_8595(this, chars, hashCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 7510, 8607);

                int
                f_387_7590_7616(System.Text.StringBuilder
                text)
                {
                    var return_v = Hash.GetFNVHashCode(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 7590, 7616);
                    return return_v;
                }


                int
                f_387_7737_7763(int
                hash)
                {
                    var return_v = LocalIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 7737, 7763);
                    return return_v;
                }


                bool
                f_387_7953_7990(string
                array, System.Text.StringBuilder
                text)
                {
                    var return_v = StringTable.TextEquals(array, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 7953, 7990);
                    return return_v;
                }


                string?
                f_387_8113_8145(System.Text.StringBuilder
                chars, int
                hashCode)
                {
                    var return_v = FindSharedEntry(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 8113, 8145);
                    return return_v;
                }


                string
                f_387_8571_8595(Roslyn.Utilities.StringTable
                this_param, System.Text.StringBuilder
                chars, int
                hashCode)
                {
                    var return_v = this_param.AddItem(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 8571, 8595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 7510, 8607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 7510, 8607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Add(string chars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 8619, 9707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8677, 8719);

                var
                hashCode = f_387_8692_8718(chars)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8793, 8815);

                var
                arr = _localTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8829, 8866);

                var
                idx = f_387_8839_8865(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8882, 8907);

                var
                text = arr[idx].Text
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 8923, 9160) || true) && (text != null && (DynAbs.Tracing.TraceSender.Expression_True(387, 8927, 8972) && arr[idx].HashCode == hashCode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 8923, 9160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9006, 9033);

                    var
                    result = arr[idx].Text
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9051, 9145) || true) && (result == chars)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 9051, 9145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9112, 9126);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(387, 9051, 9145);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 8923, 9160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9176, 9226);

                string?
                shared = f_387_9193_9225(chars, hashCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9240, 9628) || true) && (shared != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 9240, 9628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9509, 9538);

                    arr[idx].HashCode = hashCode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9556, 9579);

                    arr[idx].Text = shared;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9599, 9613);

                    return shared;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 9240, 9628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9644, 9669);

                f_387_9644_9668(this, chars, hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9683, 9696);

                return chars;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 8619, 9707);

                int
                f_387_8692_8718(string
                text)
                {
                    var return_v = Hash.GetFNVHashCode(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 8692, 8718);
                    return return_v;
                }


                int
                f_387_8839_8865(int
                hash)
                {
                    var return_v = LocalIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 8839, 8865);
                    return return_v;
                }


                string?
                f_387_9193_9225(string
                chars, int
                hashCode)
                {
                    var return_v = FindSharedEntry(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 9193, 9225);
                    return return_v;
                }


                int
                f_387_9644_9668(Roslyn.Utilities.StringTable
                this_param, string
                chars, int
                hashCode)
                {
                    this_param.AddCore(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 9644, 9668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 8619, 9707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 8619, 9707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? FindSharedEntry(char[] chars, int start, int len, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 9721, 10833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9832, 9856);

                var
                arr = s_sharedTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9870, 9908);

                int
                idx = f_387_9880_9907(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 9924, 9941);

                string?
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10091, 10096);
                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10082, 10797) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10124, 10127)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 10082, 10797))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 10082, 10797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10161, 10179);

                        e = arr[idx].Text;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10197, 10226);

                        int
                        hash = arr[idx].HashCode
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10246, 10729) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 10246, 10729);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10301, 10443) || true) && (hash == hashCode && (DynAbs.Tracing.TraceSender.Expression_True(387, 10305, 10364) && f_387_10325_10364(e, f_387_10339_10363(chars, start, len))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 10301, 10443);
                                DynAbs.Tracing.TraceSender.TraceBreak(387, 10414, 10420);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(387, 10301, 10443);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10524, 10533);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 10246, 10729);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 10246, 10729);
                            DynAbs.Tracing.TraceSender.TraceBreak(387, 10704, 10710);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 10246, 10729);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10749, 10782);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10813, 10822);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 9721, 10833);

                int
                f_387_9880_9907(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 9880, 9907);
                    return return_v;
                }


                System.Span<char>
                f_387_10339_10363(char[]
                array, int
                start, int
                length)
                {
                    var return_v = array.AsSpan<char>(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 10339, 10363);
                    return return_v;
                }


                bool
                f_387_10325_10364(string
                array, System.Span<char>
                text)
                {
                    var return_v = TextEquals(array, (System.ReadOnlySpan<char>)text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 10325, 10364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 9721, 10833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 9721, 10833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? FindSharedEntry(string chars, int start, int len, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 10845, 11950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10956, 10980);

                var
                arr = s_sharedTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 10994, 11032);

                int
                idx = f_387_11004_11031(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11048, 11065);

                string?
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11215, 11220);
                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11206, 11914) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11248, 11251)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 11206, 11914))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 11206, 11914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11285, 11303);

                        e = arr[idx].Text;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11321, 11350);

                        int
                        hash = arr[idx].HashCode
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11370, 11846) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 11370, 11846);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11425, 11560) || true) && (hash == hashCode && (DynAbs.Tracing.TraceSender.Expression_True(387, 11429, 11481) && f_387_11449_11481(e, chars, start, len)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 11425, 11560);
                                DynAbs.Tracing.TraceSender.TraceBreak(387, 11531, 11537);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(387, 11425, 11560);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11641, 11650);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 11370, 11846);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 11370, 11846);
                            DynAbs.Tracing.TraceSender.TraceBreak(387, 11821, 11827);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 11370, 11846);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11866, 11899);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 11930, 11939);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 10845, 11950);

                int
                f_387_11004_11031(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 11004, 11031);
                    return return_v;
                }


                bool
                f_387_11449_11481(string
                array, string
                text, int
                start, int
                length)
                {
                    var return_v = TextEquals(array, text, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 11449, 11481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 10845, 11950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 10845, 11950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? FindSharedEntryASCII(int hashCode, ReadOnlySpan<byte> asciiChars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 11962, 13067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12075, 12099);

                var
                arr = s_sharedTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12113, 12151);

                int
                idx = f_387_12123_12150(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12167, 12184);

                string?
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12334, 12339);
                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12325, 13031) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12367, 12370)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 12325, 13031))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 12325, 13031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12404, 12422);

                        e = arr[idx].Text;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12440, 12469);

                        int
                        hash = arr[idx].HashCode
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12489, 12963) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 12489, 12963);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12544, 12677) || true) && (hash == hashCode && (DynAbs.Tracing.TraceSender.Expression_True(387, 12548, 12598) && f_387_12568_12598(e, asciiChars)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 12544, 12677);
                                DynAbs.Tracing.TraceSender.TraceBreak(387, 12648, 12654);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(387, 12544, 12677);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12758, 12767);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 12489, 12963);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 12489, 12963);
                            DynAbs.Tracing.TraceSender.TraceBreak(387, 12938, 12944);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 12489, 12963);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 12983, 13016);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13047, 13056);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 11962, 13067);

                int
                f_387_12123_12150(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 12123, 12150);
                    return return_v;
                }


                bool
                f_387_12568_12598(string
                text, System.ReadOnlySpan<byte>
                ascii)
                {
                    var return_v = TextEqualsASCII(text, ascii);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 12568, 12598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 11962, 13067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 11962, 13067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? FindSharedEntry(char chars, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 13079, 14093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13168, 13192);

                var
                arr = s_sharedTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13206, 13244);

                int
                idx = f_387_13216_13243(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13260, 13277);

                string?
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13427, 13432);
                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13418, 14057) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13460, 13463)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 13418, 14057))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 13418, 14057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13497, 13515);

                        e = arr[idx].Text;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13535, 13989) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 13535, 13989);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13590, 13703) || true) && (f_387_13594_13602(e) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(387, 13594, 13624) && f_387_13611_13615(e, 0) == chars))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 13590, 13703);
                                DynAbs.Tracing.TraceSender.TraceBreak(387, 13674, 13680);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(387, 13590, 13703);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 13784, 13793);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 13535, 13989);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 13535, 13989);
                            DynAbs.Tracing.TraceSender.TraceBreak(387, 13964, 13970);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 13535, 13989);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14009, 14042);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14073, 14082);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 13079, 14093);

                int
                f_387_13216_13243(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 13216, 13243);
                    return return_v;
                }


                int
                f_387_13594_13602(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 13594, 13602);
                    return return_v;
                }


                char
                f_387_13611_13615(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 13611, 13615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 13079, 14093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 13079, 14093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? FindSharedEntry(StringBuilder chars, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 14105, 15185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14203, 14227);

                var
                arr = s_sharedTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14241, 14279);

                int
                idx = f_387_14251_14278(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14295, 14312);

                string?
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14462, 14467);
                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14453, 15149) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14495, 14498)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 14453, 15149))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 14453, 15149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14532, 14550);

                        e = arr[idx].Text;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14568, 14597);

                        int
                        hash = arr[idx].HashCode
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14617, 15081) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 14617, 15081);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14672, 14795) || true) && (hash == hashCode && (DynAbs.Tracing.TraceSender.Expression_True(387, 14676, 14716) && f_387_14696_14716(e, chars)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 14672, 14795);
                                DynAbs.Tracing.TraceSender.TraceBreak(387, 14766, 14772);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(387, 14672, 14795);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 14876, 14885);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 14617, 15081);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 14617, 15081);
                            DynAbs.Tracing.TraceSender.TraceBreak(387, 15056, 15062);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 14617, 15081);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15101, 15134);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15165, 15174);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 14105, 15185);

                int
                f_387_14251_14278(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 14251, 14278);
                    return return_v;
                }


                bool
                f_387_14696_14716(string
                array, System.Text.StringBuilder
                text)
                {
                    var return_v = TextEquals(array, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 14696, 14716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 14105, 15185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 14105, 15185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? FindSharedEntry(string chars, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 15197, 16260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15288, 15312);

                var
                arr = s_sharedTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15326, 15364);

                int
                idx = f_387_15336_15363(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15380, 15397);

                string?
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15547, 15552);
                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15538, 16224) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15580, 15583)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 15538, 16224))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 15538, 16224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15617, 15635);

                        e = arr[idx].Text;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15653, 15682);

                        int
                        hash = arr[idx].HashCode
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15702, 16156) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 15702, 16156);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15757, 15870) || true) && (hash == hashCode && (DynAbs.Tracing.TraceSender.Expression_True(387, 15761, 15791) && e == chars))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 15757, 15870);
                                DynAbs.Tracing.TraceSender.TraceBreak(387, 15841, 15847);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(387, 15757, 15870);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 15951, 15960);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 15702, 16156);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 15702, 16156);
                            DynAbs.Tracing.TraceSender.TraceBreak(387, 16131, 16137);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 15702, 16156);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16176, 16209);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16240, 16249);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 15197, 16260);

                int
                f_387_15336_15363(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 15336, 15363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 15197, 16260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 15197, 16260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string AddItem(char[] chars, int start, int len, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 16274, 16485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16369, 16410);

                var
                text = f_387_16380_16409(chars, start, len)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16424, 16448);

                f_387_16424_16447(this, text, hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16462, 16474);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 16274, 16485);

                string
                f_387_16380_16409(char[]
                value, int
                startIndex, int
                length)
                {
                    var return_v = new string(value, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 16380, 16409);
                    return return_v;
                }


                int
                f_387_16424_16447(Roslyn.Utilities.StringTable
                this_param, string
                chars, int
                hashCode)
                {
                    this_param.AddCore(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 16424, 16447);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 16274, 16485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 16274, 16485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string AddItem(string chars, int start, int len, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 16497, 16706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16592, 16631);

                var
                text = f_387_16603_16630(chars, start, len)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16645, 16669);

                f_387_16645_16668(this, text, hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16683, 16695);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 16497, 16706);

                string
                f_387_16603_16630(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 16603, 16630);
                    return return_v;
                }


                int
                f_387_16645_16668(Roslyn.Utilities.StringTable
                this_param, string
                chars, int
                hashCode)
                {
                    this_param.AddCore(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 16645, 16668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 16497, 16706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 16497, 16706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string AddItem(char chars, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 16718, 16898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16791, 16823);

                var
                text = f_387_16802_16822(chars, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16837, 16861);

                f_387_16837_16860(this, text, hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16875, 16887);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 16718, 16898);

                string
                f_387_16802_16822(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 16802, 16822);
                    return return_v;
                }


                int
                f_387_16837_16860(Roslyn.Utilities.StringTable
                this_param, string
                chars, int
                hashCode)
                {
                    this_param.AddCore(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 16837, 16860);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 16718, 16898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 16718, 16898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string AddItem(StringBuilder chars, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 16910, 17095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 16992, 17020);

                var
                text = f_387_17003_17019(chars)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17034, 17058);

                f_387_17034_17057(this, text, hashCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17072, 17084);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 16910, 17095);

                string
                f_387_17003_17019(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 17003, 17019);
                    return return_v;
                }


                int
                f_387_17034_17057(Roslyn.Utilities.StringTable
                this_param, string
                chars, int
                hashCode)
                {
                    this_param.AddCore(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 17034, 17057);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 16910, 17095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 16910, 17095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddCore(string chars, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 17109, 17520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17266, 17298);

                f_387_17266_17297(this, hashCode, chars);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17357, 17379);

                var
                arr = _localTable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17393, 17430);

                var
                idx = f_387_17403_17429(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17444, 17473);

                arr[idx].HashCode = hashCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 17487, 17509);

                arr[idx].Text = chars;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 17109, 17520);

                int
                f_387_17266_17297(Roslyn.Utilities.StringTable
                this_param, int
                hashCode, string
                text)
                {
                    this_param.AddSharedEntry(hashCode, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 17266, 17297);
                    return 0;
                }


                int
                f_387_17403_17429(int
                hash)
                {
                    var return_v = LocalIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 17403, 17429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 17109, 17520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 17109, 17520);
            }
        }

        private void AddSharedEntry(int hashCode, string text)
        {
            var arr = s_sharedTable;
            int idx = SharedIdxFromHash(hashCode);

            // try finding an empty spot in the bucket
            // we use quadratic probing here
            // bucket positions are (n^2 + n)/2 relative to the masked hashcode
            int curIdx = idx;
            for (int i = 1; i < SharedBucketSize + 1; i++)
            {
                if (arr[curIdx].Text == null)
                {
                    idx = curIdx;
                    goto foundIdx;
                }

                curIdx = (curIdx + i) & SharedSizeMask;
            }

            // or pick a random victim within the bucket range
            // and replace with new entry
            var i1 = LocalNextRandom() & SharedBucketSizeMask;
            idx = (idx + ((i1 * i1 + i1) / 2)) & SharedSizeMask;

foundIdx:
            arr[idx].HashCode = hashCode;
            Volatile.Write(ref arr[idx].Text, text);
        }

        internal static string AddShared(StringBuilder chars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 18580, 18926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 18658, 18700);

                var
                hashCode = f_387_18673_18699(chars)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 18716, 18766);

                string?
                shared = f_387_18733_18765(chars, hashCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 18780, 18861) || true) && (shared != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 18780, 18861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 18832, 18846);

                    return shared;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 18780, 18861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 18877, 18915);

                return f_387_18884_18914(hashCode, chars);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 18580, 18926);

                int
                f_387_18673_18699(System.Text.StringBuilder
                text)
                {
                    var return_v = Hash.GetFNVHashCode(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 18673, 18699);
                    return return_v;
                }


                string?
                f_387_18733_18765(System.Text.StringBuilder
                chars, int
                hashCode)
                {
                    var return_v = FindSharedEntry(chars, hashCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 18733, 18765);
                    return return_v;
                }


                string
                f_387_18884_18914(int
                hashCode, System.Text.StringBuilder
                builder)
                {
                    var return_v = AddSharedSlow(hashCode, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 18884, 18914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 18580, 18926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 18580, 18926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string AddSharedSlow(int hashCode, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 18938, 19149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19035, 19068);

                string
                text = f_387_19049_19067(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19082, 19112);

                f_387_19082_19111(hashCode, text);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19126, 19138);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 18938, 19149);

                string
                f_387_19049_19067(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 19049, 19067);
                    return return_v;
                }


                int
                f_387_19082_19111(int
                hashCode, string
                text)
                {
                    AddSharedSlow(hashCode, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 19082, 19111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 18938, 19149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 18938, 19149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string AddSharedUTF8(ReadOnlySpan<byte> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 19161, 19624);
                bool isAscii = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19248, 19308);

                int
                hashCode = f_387_19263_19307(bytes, out isAscii)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19324, 19550) || true) && (isAscii)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 19324, 19550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19369, 19424);

                    string?
                    shared = f_387_19386_19423(hashCode, bytes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19442, 19535) || true) && (shared != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 19442, 19535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19502, 19516);

                        return shared;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(387, 19442, 19535);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 19324, 19550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19566, 19613);

                return f_387_19573_19612(hashCode, bytes, isAscii);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 19161, 19624);

                int
                f_387_19263_19307(System.ReadOnlySpan<byte>
                data, out bool
                isAscii)
                {
                    var return_v = Hash.GetFNVHashCode(data, out isAscii);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 19263, 19307);
                    return return_v;
                }


                string?
                f_387_19386_19423(int
                hashCode, System.ReadOnlySpan<byte>
                asciiChars)
                {
                    var return_v = FindSharedEntryASCII(hashCode, asciiChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 19386, 19423);
                    return return_v;
                }


                string
                f_387_19573_19612(int
                hashCode, System.ReadOnlySpan<byte>
                utf8Bytes, bool
                isAscii)
                {
                    var return_v = AddSharedSlow(hashCode, utf8Bytes, isAscii);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 19573, 19612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 19161, 19624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 19161, 19624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string AddSharedSlow(int hashCode, ReadOnlySpan<byte> utf8Bytes, bool isAscii)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 19636, 20507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19754, 19766);

                string
                text
                = default(string);

                unsafe
                {
                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19805, 19994);

                    fixed (byte*
    bytes = &utf8Bytes.GetPinnableReference()
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 19917, 19973);

                        text = f_387_19924_19972(f_387_19924_19937(), bytes, utf8Bytes.Length);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 20378, 20468) || true) && (isAscii)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 20378, 20468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 20423, 20453);

                    f_387_20423_20452(hashCode, text);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 20378, 20468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 20484, 20496);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 19636, 20507);

                System.Text.Encoding
                f_387_19924_19937()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 19924, 19937);
                    return return_v;
                }


                unsafe string
                f_387_19924_19972(System.Text.Encoding
                this_param, byte*
                bytes, int
                byteCount)
                {
                    var return_v = this_param.GetString(bytes, byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 19924, 19972);
                    return return_v;
                }


                int
                f_387_20423_20452(int
                hashCode, string
                text)
                {
                    AddSharedSlow(hashCode, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 20423, 20452);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 19636, 20507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 19636, 20507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddSharedSlow(int hashCode, string text)
        {
            var arr = s_sharedTable;
            int idx = SharedIdxFromHash(hashCode);

            // try finding an empty spot in the bucket
            // we use quadratic probing here
            // bucket positions are (n^2 + n)/2 relative to the masked hashcode
            int curIdx = idx;
            for (int i = 1; i < SharedBucketSize + 1; i++)
            {
                if (arr[curIdx].Text == null)
                {
                    idx = curIdx;
                    goto foundIdx;
                }

                curIdx = (curIdx + i) & SharedSizeMask;
            }

            // or pick a random victim within the bucket range
            // and replace with new entry
            var i1 = SharedNextRandom() & SharedBucketSizeMask;
            idx = (idx + ((i1 * i1 + i1) / 2)) & SharedSizeMask;

foundIdx:
            arr[idx].HashCode = hashCode;
            Volatile.Write(ref arr[idx].Text, text);
        }

        private static int LocalIdxFromHash(int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 21574, 21683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 21644, 21672);

                return hash & LocalSizeMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 21574, 21683);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 21574, 21683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 21574, 21683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int SharedIdxFromHash(int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 21695, 21896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 21828, 21885);

                return (hash ^ (hash >> LocalSizeBits)) & SharedSizeMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 21695, 21896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 21695, 21896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 21695, 21896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int LocalNextRandom()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 21908, 21995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 21962, 21984);

                return _localRandom++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(387, 21908, 21995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 21908, 21995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 21908, 21995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int SharedNextRandom()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 22007, 22141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22069, 22130);

                return f_387_22076_22129(ref StringTable.s_sharedRandom);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 22007, 22141);

                int
                f_387_22076_22129(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 22076, 22129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 22007, 22141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 22007, 22141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TextEquals(string array, string text, int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 22153, 22655);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22259, 22347) || true) && (f_387_22263_22275(array) != length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 22259, 22347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22319, 22332);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 22259, 22347);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22434, 22439);

                    // use array.Length to eliminate the range check
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22425, 22616) || true) && (i < f_387_22445_22457(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22459, 22462)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 22425, 22616))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 22425, 22616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22496, 22601) || true) && (f_387_22500_22508(array, i) != f_387_22512_22527(text, start + i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 22496, 22601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22569, 22582);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 22496, 22601);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22632, 22644);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 22153, 22655);

                int
                f_387_22263_22275(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 22263, 22275);
                    return return_v;
                }


                int
                f_387_22445_22457(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 22445, 22457);
                    return return_v;
                }


                char
                f_387_22500_22508(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 22500, 22508);
                    return return_v;
                }


                char
                f_387_22512_22527(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 22512, 22527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 22153, 22655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 22153, 22655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TextEquals(string array, StringBuilder text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 22667, 23268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22757, 22850) || true) && (f_387_22761_22773(array) != f_387_22777_22788(text))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 22757, 22850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 22822, 22835);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 22757, 22850);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23050, 23070);

                    // interestingly, stringbuilder holds the list of chunks by the tail
                    // so accessing positions at the beginning may cost more than those at the end.
                    for (var
        i = f_387_23054_23066(array) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23041, 23229) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23080, 23083)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 23041, 23229))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 23041, 23229);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23117, 23214) || true) && (f_387_23121_23129(array, i) != f_387_23133_23140(text, i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 23117, 23214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23182, 23195);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 23117, 23214);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23245, 23257);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 22667, 23268);

                int
                f_387_22761_22773(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 22761, 22773);
                    return return_v;
                }


                int
                f_387_22777_22788(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 22777, 22788);
                    return return_v;
                }


                int
                f_387_23054_23066(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 23054, 23066);
                    return return_v;
                }


                char
                f_387_23121_23129(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 23121, 23129);
                    return return_v;
                }


                char
                f_387_23133_23140(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 23133, 23140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 22667, 23268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 22667, 23268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TextEqualsASCII(string text, ReadOnlySpan<byte> ascii)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(387, 23280, 23935);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23400, 23405);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23391, 23580) || true) && (i < ascii.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23425, 23428)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 23391, 23580))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 23391, 23580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23462, 23565);

                        f_387_23462_23564((ascii[i] & 0x80) == 0, $"The {nameof(ascii)} input to this method must be valid ASCII.");
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 190);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23604, 23697) || true) && (ascii.Length != f_387_23624_23635(text))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 23604, 23697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23669, 23682);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(387, 23604, 23697);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23722, 23727);

                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23713, 23896) || true) && (i < ascii.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23747, 23750)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(387, 23713, 23896))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 23713, 23896);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23784, 23881) || true) && (ascii[i] != f_387_23800_23807(text, i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(387, 23784, 23881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23849, 23862);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(387, 23784, 23881);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(387, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(387, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 23912, 23924);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(387, 23280, 23935);

                int
                f_387_23462_23564(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 23462, 23564);
                    return 0;
                }


                int
                f_387_23624_23635(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 23624, 23635);
                    return return_v;
                }


                char
                f_387_23800_23807(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 23800, 23807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 23280, 23935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 23280, 23935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TextEquals(string array, ReadOnlySpan<char> text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(387, 24031, 24087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 24034, 24087);
                return text.Equals(f_387_24046_24060(array), StringComparison.Ordinal); DynAbs.Tracing.TraceSender.TraceExitMethod(387, 24031, 24087);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(387, 24031, 24087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 24031, 24087);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.ReadOnlySpan<char>
            f_387_24046_24060(string
            text)
            {
                var return_v = text.AsSpan();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 24046, 24060);
                return return_v;
            }

        }

        static StringTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(387, 621, 24095);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1119, 1137);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1166, 1198);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1227, 1256);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1325, 1344);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1373, 1407);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1436, 1467);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1575, 1595);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1624, 1666);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 1695, 1738);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 2501, 2538);
            s_sharedTable = new Entry[SharedSize]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 2921, 2959);
            s_sharedRandom = f_387_2938_2959(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(387, 3347, 3374);
            s_staticPool = f_387_3362_3374(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(387, 621, 24095);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(387, 621, 24095);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(387, 621, 24095);

        int
        f_387_2781_2802()
        {
            var return_v = Environment.TickCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 2781, 2802);
            return return_v;
        }


        static int
        f_387_2938_2959()
        {
            var return_v = Environment.TickCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(387, 2938, 2959);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>?
        f_387_3015_3019_C(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(387, 2972, 3042);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.StringTable>
        f_387_3362_3374()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(387, 3362, 3374);
            return return_v;
        }

    }
}
