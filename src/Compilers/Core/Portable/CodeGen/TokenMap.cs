// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class TokenMap
    {
        private readonly ConcurrentDictionary<IReferenceOrISignature, uint> _itemIdentityToToken;

        private object[] _items;

        private int _count;

        internal TokenMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(88, 1305, 1328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1173, 1201);
                
                this._itemIdentityToToken = f_88_1196_1201();

                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IReferenceOrISignature, uint>
                f_88_1196_1201()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IReferenceOrISignature, uint>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1196, 1201);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1229, 1259);
                this._items = f_88_1238_1259(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1282, 1292);
                this._count = 0; DynAbs.Tracing.TraceSender.TraceExitConstructor(88, 1305, 1328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(88, 1305, 1328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 1305, 1328);
            }
        }

        public uint GetOrAddTokenFor(IReference item, out bool referenceAdded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(88, 1340, 1720);
                uint token = default(uint);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1435, 1624) || true) && (f_88_1439_1521(_itemIdentityToToken, f_88_1472_1504(item), out token))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(88, 1435, 1624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1555, 1578);

                    referenceAdded = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1596, 1609);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(88, 1435, 1624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1640, 1709);

                return f_88_1647_1708(this, f_88_1655_1687(item), out referenceAdded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(88, 1340, 1720);

                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_88_1472_1504(Microsoft.Cci.IReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1472, 1504);
                    return return_v;
                }


                bool
                f_88_1439_1521(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IReferenceOrISignature, uint>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                key, out uint
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1439, 1521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_88_1655_1687(Microsoft.Cci.IReference
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1655, 1687);
                    return return_v;
                }


                uint
                f_88_1647_1708(Microsoft.CodeAnalysis.CodeGen.TokenMap
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item, out bool
                referenceAdded)
                {
                    var return_v = this_param.AddItem(item, out referenceAdded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1647, 1708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(88, 1340, 1720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 1340, 1720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetOrAddTokenFor(ISignature item, out bool referenceAdded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(88, 1732, 2112);
                uint token = default(uint);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1827, 2016) || true) && (f_88_1831_1913(_itemIdentityToToken, f_88_1864_1896(item), out token))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(88, 1827, 2016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1947, 1970);

                    referenceAdded = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 1988, 2001);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(88, 1827, 2016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2032, 2101);

                return f_88_2039_2100(this, f_88_2047_2079(item), out referenceAdded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(88, 1732, 2112);

                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_88_1864_1896(Microsoft.Cci.ISignature
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1864, 1896);
                    return return_v;
                }


                bool
                f_88_1831_1913(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IReferenceOrISignature, uint>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                key, out uint
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1831, 1913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IReferenceOrISignature
                f_88_2047_2079(Microsoft.Cci.ISignature
                item)
                {
                    var return_v = new Microsoft.CodeAnalysis.IReferenceOrISignature(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 2047, 2079);
                    return return_v;
                }


                uint
                f_88_2039_2100(Microsoft.CodeAnalysis.CodeGen.TokenMap
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                item, out bool
                referenceAdded)
                {
                    var return_v = this_param.AddItem(item, out referenceAdded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 2039, 2100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(88, 1732, 2112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 1732, 2112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private uint AddItem(IReferenceOrISignature item, out bool referenceAdded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(88, 2124, 3704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2223, 2234);

                uint
                token
                = default(uint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2437, 2457);
                // NOTE: cannot use GetOrAdd here since items and itemToToken must be in sync
                // so if we do need to add we have to take a lock and modify both collections.
                lock (_itemIdentityToToken)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2491, 3649) || true) && (!f_88_2496_2545(_itemIdentityToToken, item, out token))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(88, 2491, 3649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2587, 2608);

                        token = (uint)_count;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2682, 2740);

                        referenceAdded = f_88_2699_2739(_itemIdentityToToken, item, token);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2762, 2791);

                        f_88_2762_2790(referenceAdded);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2815, 2842);

                        var
                        count = (int)token + 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2864, 2883);

                        var
                        items = _items
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2905, 3467) || true) && (f_88_2909_2921(items) > count)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(88, 2905, 3467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 2979, 3015);

                            items[(int)token] = item.AsObject();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(88, 2905, 3467);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(88, 2905, 3467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3186, 3234);

                            f_88_3186_3233(ref items, f_88_3210_3232(8, count * 2));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3260, 3296);

                            items[(int)token] = item.AsObject();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3410, 3444);

                            f_88_3410_3443(ref _items, items);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(88, 2905, 3467);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3491, 3525);

                        f_88_3491_3524(ref _count, count);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(88, 2491, 3649);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(88, 2491, 3649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3607, 3630);

                        referenceAdded = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(88, 2491, 3649);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3680, 3693);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(88, 2124, 3704);

                bool
                f_88_2496_2545(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IReferenceOrISignature, uint>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                key, out uint
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 2496, 2545);
                    return return_v;
                }


                bool
                f_88_2699_2739(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IReferenceOrISignature, uint>
                this_param, Microsoft.CodeAnalysis.IReferenceOrISignature
                key, uint
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 2699, 2739);
                    return return_v;
                }


                int
                f_88_2762_2790(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 2762, 2790);
                    return 0;
                }


                int
                f_88_2909_2921(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(88, 2909, 2921);
                    return return_v;
                }


                int
                f_88_3210_3232(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 3210, 3232);
                    return return_v;
                }


                int
                f_88_3186_3233(ref object[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 3186, 3233);
                    return 0;
                }


                int
                f_88_3410_3443(ref object[]
                location, object[]
                value)
                {
                    Volatile.Write(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 3410, 3443);
                    return 0;
                }


                int
                f_88_3491_3524(ref int
                location, int
                value)
                {
                    Volatile.Write(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 3491, 3524);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(88, 2124, 3704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 2124, 3704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetItem(uint token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(88, 3716, 4041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 3926, 3988);

                f_88_3926_3987(token < (uint)_count && (DynAbs.Tracing.TraceSender.Expression_True(88, 3939, 3986) && _count <= f_88_3973_3986(_items)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 4004, 4030);

                return _items[(int)token];
                DynAbs.Tracing.TraceSender.TraceExitMethod(88, 3716, 4041);

                int
                f_88_3973_3986(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(88, 3973, 3986);
                    return return_v;
                }


                int
                f_88_3926_3987(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 3926, 3987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(88, 3716, 4041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 3716, 4041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReadOnlySpan<object> GetAllItems()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(88, 4225, 4847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 4545, 4583);

                int
                count = f_88_4557_4582(ref _count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 4638, 4681);

                object[]
                items = f_88_4655_4680(ref _items)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(88, 4787, 4836);

                return f_88_4794_4835(items, 0, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(88, 4225, 4847);

                int
                f_88_4557_4582(ref int
                location)
                {
                    var return_v = Volatile.Read(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 4557, 4582);
                    return return_v;
                }


                object[]
                f_88_4655_4680(ref object[]
                location)
                {
                    var return_v = Volatile.Read(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 4655, 4680);
                    return return_v;
                }


                System.ReadOnlySpan<object>
                f_88_4794_4835(object[]
                array, int
                start, int
                length)
                {
                    var return_v = new System.ReadOnlySpan<object>(array, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 4794, 4835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(88, 4225, 4847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 4225, 4847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TokenMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(88, 1058, 4854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(88, 1058, 4854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(88, 1058, 4854);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(88, 1058, 4854);

        object[]
        f_88_1238_1259()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(88, 1238, 1259);
            return return_v;
        }

    }
}
