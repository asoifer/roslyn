// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Threading;

namespace Roslyn.Utilities
{
    internal class TextKeyedCache<T> where T : class
    {
        private class SharedEntryValue
        {
            public readonly string Text;

            public readonly T Item;

            public SharedEntryValue(string Text, T item)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(390, 891, 1035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 833, 837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 870, 874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 968, 985);

                    this.Text = Text;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1003, 1020);

                    this.Item = item;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(390, 891, 1035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 891, 1035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 891, 1035);
                }
            }

            static SharedEntryValue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(390, 755, 1046);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(390, 755, 1046);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 755, 1046);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(390, 755, 1046);
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

        private readonly (string Text, int HashCode, T Item)[] _localTable;

        private static readonly (int HashCode, SharedEntryValue Entry)[] s_sharedTable;

        private readonly (int HashCode, SharedEntryValue Entry)[] _sharedTableInst;

        private readonly StringTable _strings;

        private Random? _random;

        internal TextKeyedCache() : this(f_390_3045_3049_C(null))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(390, 2999, 3072);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(390, 2999, 3072);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 2999, 3072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 2999, 3072);
            }
        }

        private TextKeyedCache(ObjectPool<TextKeyedCache<T>>? pool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(390, 3160, 3311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 2110, 2174);
                this._localTable = new (string Text, int HashCode, T Item)[LocalSize]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 2736, 2768);
                this._sharedTableInst = s_sharedTable; DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 2810, 2818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 2979, 2986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 3371, 3376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 3244, 3257);

                _pool = pool;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 3271, 3300);

                _strings = f_390_3282_3299();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(390, 3160, 3311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 3160, 3311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 3160, 3311);
            }
        }

        private readonly ObjectPool<TextKeyedCache<T>>? _pool;

        private static readonly ObjectPool<TextKeyedCache<T>> s_staticPool;

        private static ObjectPool<TextKeyedCache<T>> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(390, 3481, 3749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 3563, 3712);

                var
                pool = f_390_3574_3711(pool => new TextKeyedCache<T>(pool), f_390_3680_3706() * 4)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 3726, 3738);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(390, 3481, 3749);

                int
                f_390_3680_3706()
                {
                    var return_v = Environment.ProcessorCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(390, 3680, 3706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.TextKeyedCache<T>>
                f_390_3574_3711(System.Func<Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.TextKeyedCache<T>>, Roslyn.Utilities.TextKeyedCache<T>>
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.TextKeyedCache<T>>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 3574, 3711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 3481, 3749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 3481, 3749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TextKeyedCache<T> GetInstance()
        {
            return s_staticPool.Allocate();
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(390, 3885, 4174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 4145, 4163);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_pool, 390, 4145, 4162)?.Free(this), 390, 4151, 4162);
                DynAbs.Tracing.TraceSender.TraceExitMethod(390, 3885, 4174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 3885, 4174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 3885, 4174);
            }
        }

        internal T? FindItem(char[] chars, int start, int len, int hashCode)
        {
            // get direct element reference to avoid extra range checks
            ref var localSlot = ref _localTable[LocalIdxFromHash(hashCode)];

            var text = localSlot.Text;

            if (text != null && localSlot.HashCode == hashCode)
            {
                if (StringTable.TextEquals(text, chars.AsSpan(start, len)))
                {
                    return localSlot.Item;
                }
            }

            SharedEntryValue? e = FindSharedEntry(chars, start, len, hashCode);
            if (e != null)
            {
                localSlot.HashCode = hashCode;
                localSlot.Text = e.Text;

                var tk = e.Item;
                localSlot.Item = tk;

                return tk;
            }

            return null!;
        }

        private SharedEntryValue? FindSharedEntry(char[] chars, int start, int len, int hashCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(390, 5135, 6261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5249, 5276);

                var
                arr = _sharedTableInst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5290, 5328);

                int
                idx = f_390_5300_5327(hashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5344, 5371);

                SharedEntryValue?
                e = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5385, 5394);

                int
                hash
                = default(int);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5546, 5551);

                    // we use quadratic probing here
                    // bucket positions are (n^2 + n)/2 relative to the masked hashcode
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5537, 6225) || true) && (i < SharedBucketSize + 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5579, 5582)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(390, 5537, 6225))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(390, 5537, 6225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5616, 5637);

                        (hash, e) = arr[idx];

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5657, 6157) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(390, 5657, 6157);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5712, 5871) || true) && (hash == hashCode && (DynAbs.Tracing.TraceSender.Expression_True(390, 5716, 5792) && f_390_5736_5792(e.Text, f_390_5767_5791(chars, start, len))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(390, 5712, 5871);
                                DynAbs.Tracing.TraceSender.TraceBreak(390, 5842, 5848);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(390, 5712, 5871);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 5952, 5961);

                            e = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(390, 5657, 6157);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(390, 5657, 6157);
                            DynAbs.Tracing.TraceSender.TraceBreak(390, 6132, 6138);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(390, 5657, 6157);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 6177, 6210);

                        idx = (idx + i) & SharedSizeMask;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(390, 1, 689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(390, 1, 689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 6241, 6250);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitMethod(390, 5135, 6261);

                int
                f_390_5300_5327(int
                hash)
                {
                    var return_v = SharedIdxFromHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 5300, 5327);
                    return return_v;
                }


                System.Span<char>
                f_390_5767_5791(char[]
                array, int
                start, int
                length)
                {
                    var return_v = array.AsSpan<char>(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 5767, 5791);
                    return return_v;
                }


                bool
                f_390_5736_5792(string
                array, System.Span<char>
                text)
                {
                    var return_v = StringTable.TextEquals(array, (System.ReadOnlySpan<char>)text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 5736, 5792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 5135, 6261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 5135, 6261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddItem(char[] chars, int start, int len, int hashCode, T item)
        {
            var text = _strings.Add(chars, start, len);

            // add to the shared table first (in case someone looks for same item)
            var e = new SharedEntryValue(text, item);
            AddSharedEntry(hashCode, e);

            // add to the local table too
            ref var localSlot = ref _localTable[LocalIdxFromHash(hashCode)];
            localSlot.HashCode = hashCode;
            localSlot.Text = text;
            localSlot.Item = item;
        }

        private void AddSharedEntry(int hashCode, SharedEntryValue e)
        {
            var arr = _sharedTableInst;
            int idx = SharedIdxFromHash(hashCode);

            // try finding an empty spot in the bucket
            // we use quadratic probing here
            // bucket positions are (n^2 + n)/2 relative to the masked hashcode
            int curIdx = idx;
            for (int i = 1; i < SharedBucketSize + 1; i++)
            {
                if (arr[curIdx].Entry == null)
                {
                    idx = curIdx;
                    goto foundIdx;
                }

                curIdx = (curIdx + i) & SharedSizeMask;
            }

            // or pick a random victim within the bucket range
            // and replace with new entry
            var i1 = NextRandom() & SharedBucketSizeMask;
            idx = (idx + ((i1 * i1 + i1) / 2)) & SharedSizeMask;

foundIdx:
            arr[idx].HashCode = hashCode;
            Volatile.Write(ref arr[idx].Entry, e);
        }

        private static int LocalIdxFromHash(int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(390, 7915, 8024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 7985, 8013);

                return hash & LocalSizeMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(390, 7915, 8024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 7915, 8024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 7915, 8024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int SharedIdxFromHash(int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(390, 8036, 8237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8169, 8226);

                return (hash ^ (hash >> LocalSizeBits)) & SharedSizeMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(390, 8036, 8237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 8036, 8237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 8036, 8237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int NextRandom()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(390, 8249, 8506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8298, 8314);

                var
                r = _random
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8328, 8406) || true) && (r != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(390, 8328, 8406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8375, 8391);

                    return f_390_8382_8390(r);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(390, 8328, 8406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8422, 8439);

                r = f_390_8426_8438();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8453, 8465);

                _random = r;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 8479, 8495);

                return f_390_8486_8494(r);
                DynAbs.Tracing.TraceSender.TraceExitMethod(390, 8249, 8506);

                int
                f_390_8382_8390(System.Random
                this_param)
                {
                    var return_v = this_param.Next();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 8382, 8390);
                    return return_v;
                }


                System.Random
                f_390_8426_8438()
                {
                    var return_v = new System.Random();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 8426, 8438);
                    return return_v;
                }


                int
                f_390_8486_8494(System.Random
                this_param)
                {
                    var return_v = this_param.Next();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 8486, 8494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(390, 8249, 8506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 8249, 8506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TextKeyedCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(390, 570, 8513);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1281, 1299);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1328, 1360);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1389, 1418);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1487, 1506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1535, 1569);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1598, 1629);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1737, 1757);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1786, 1828);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 1857, 1900);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 2466, 2536);
            s_sharedTable = new (int HashCode, SharedEntryValue Entry)[SharedSize]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(390, 3441, 3468);
            s_staticPool = f_390_3456_3468(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(390, 570, 8513);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(390, 570, 8513);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(390, 570, 8513);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.TextKeyedCache<T>>?
        f_390_3045_3049_C(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.TextKeyedCache<T>>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(390, 2999, 3072);
            return return_v;
        }


        static Roslyn.Utilities.StringTable
        f_390_3282_3299()
        {
            var return_v = new Roslyn.Utilities.StringTable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 3282, 3299);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Roslyn.Utilities.TextKeyedCache<T>>
        f_390_3456_3468()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(390, 3456, 3468);
            return return_v;
        }

    }
}
